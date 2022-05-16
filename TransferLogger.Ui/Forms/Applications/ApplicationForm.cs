using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.BusinessLogic.Models;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

using DalApplication = TransferLogger.Dal.DataModels.Applications.Application;

namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ApplicationForm : Form
    {
        private int _currentEvaluationId = 0;

        private readonly DalApplication              _application;
        private readonly Dictionary<int, Evaluation> _evaluations;
        private readonly Dictionary<int, Course>     _courses;
        private readonly List<Lookup>                _activeEvaluationStatuses;
        private readonly bool                        _readOnly;

        public ApplicationForm(int appId, bool readOnly = false)
        {
            InitializeComponent();

            using var dc = new Dc();

            _application = dc.GetApplication(appId);
            _evaluations = _application.Evaluations.ToDictionary(e => e.EvaluationId);

            _courses = dc.Courses
                .Where(c => c.ProgramId == _application.TargetProgramId)
                .ToDictionary(c => c.CourseId);

            var evaluationStatuses = new HashSet<EvaluationStatus>
            {
                EvaluationStatus.InProcess,
                EvaluationStatus.Matched,
                EvaluationStatus.NotMatched,
            };

            _activeEvaluationStatuses = EnumUtils.GetLookups(evaluationStatuses);

            _readOnly = readOnly || _application.ApplicationStatus == ApplicationStatus.Completed;

            Text = $"Transfer application for {_application.Student.DisplayString} (Id: {_application.ApplicationId})";

            if (_readOnly)
                _btnSave.Text = "Ok";

            FormUtils.SetReadOnly(_btnSendEmail, readOnly);
            FormUtils.SetReadOnly(_btnExportExcel, readOnly);

            SetData(true);
            SetEvents();
        }

        private void SetData(bool initial = false)
        {
            if (_currentEvaluationId <= 0)
                _currentEvaluationId = _application.Evaluations.First()
                    .EvaluationId;

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = _application.Evaluations
                .Select(e => new EvaluationModel(e, _application))
                .ToList();

            if (_currentEvaluationId > 0)
                _grid.SelectRow<IIdentifiable>(i => i.Id == _currentEvaluationId);

            _grid.SelectionChanged += _grid_SelectionChanged;

            if (initial)
            {
                _tbStudent.Text       = _application.Student.DisplayString;
                _tbOrganization.Text  = _application.SourceOrganization.DisplayString;
                _tbTargetProgram.Text = _application.TargetProgram.DisplayString;
                _tbCreatedAt.Text     = _application.CreatedAt.ToDisplayString();

                if (_application.CompletedAt.HasValue)
                    _tbCompletedAt.Text = _application.CompletedAt.Value.ToDisplayString();
                else
                    _lCompletedAt.Visible = _tbCompletedAt.Visible = false;

                _cbApplicationStatus.FillLookups(_application.ApplicationStatus);
                _cbEvaluationStatus.FillLookups<EvaluationStatus>();

                var courses = _courses.Values
                    .Select(c => new Lookup(c.CourseId, c.DisplayString))
                    .ToList();

                _cbMatchedCourses.FillLookups(courses, new Lookup(-1, "None"));

                SetEvaluation();
            }
        }

        private void SetEvaluationStatuses()
        {
            var evaluation = _evaluations[_currentEvaluationId];

            _cbEvaluationStatus.SelectedValueChanged -= _cbEvaluationStatus_SelectedValueChanged;

            if (evaluation.EvaluationStatus == EvaluationStatus.MatchedByHistory || evaluation.EvaluationStatus == EvaluationStatus.RejectedByHistory)
            {
                _cbEvaluationStatus.FillLookups(evaluation.EvaluationStatus);
            }
            else
            {
                var lookups = _activeEvaluationStatuses;

                if ((evaluation.MatchedCourseId ?? 0) <= 0)
                {
                    lookups = lookups
                        .Where(l => l.Value != (int)EvaluationStatus.Matched)
                        .ToList();
                }

                _cbEvaluationStatus.FillLookups(lookups, Convert.ToInt32(evaluation.EvaluationStatus));
            }

            _cbEvaluationStatus.SelectedValueChanged += _cbEvaluationStatus_SelectedValueChanged;
        }

        private void SetEvaluation()
        {
            if (_grid.CurrentRow?.DataBoundItem is EvaluationModel model)
            {
                _currentEvaluationId = model.Id;

                _tbCourse.Text          = model.Course;
                _tbSuggestedCourse.Text = model.SuggestedCourse;
                _tbEvaluator.Text       = model.Instructor;
                _tbComment.Text         = model.Comment;

                _btnViewSuggestedCourse.Enabled = model.SuggestedCourseId > 0;
                _btnViewMatchedCourse.Enabled   = model.MatchedCourseId > 0;

                _cbMatchedCourses.SelectedValueChanged -= _cbMatchedCourses_SelectedValueChanged;

                _cbMatchedCourses.SelectedValue = model.MatchedCourseId ?? 0;

                _cbMatchedCourses.SelectedValueChanged += _cbMatchedCourses_SelectedValueChanged;

                SetEvaluationStatuses();

                var readOnly = _readOnly ||
                    model.Status == EvaluationStatus.MatchedByHistory ||
                    model.Status == EvaluationStatus.RejectedByHistory;

                _cbEvaluationStatus.Enabled = _cbMatchedCourses.Enabled = !readOnly;

                FormUtils.SetReadOnly(_tbComment, readOnly);
            }
        }

        private void SetEvents()
        {
            _btnViewCourse.Click          += ViewCourse;
            _btnViewSuggestedCourse.Click += ViewCourse;
            _btnViewMatchedCourse.Click   += ViewCourse;

            _tbComment.TextChanged += _tbComment_TextChanged;

            _btnSendEmail.Click   += _btnSendEmail_Click;
            _btnExportExcel.Click += _btnExportExcel_Click;
            _btnSave.Click        += _btnSave_Click;
            _btnCancel.Click      += _btnCancel_Click;
        }

        private void ViewCourse(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is EvaluationModel model)
            {
                int courseId = 0;

                if (sender == _btnViewCourse)
                    courseId = model.CourseId;
                if (sender == _btnViewSuggestedCourse)
                    courseId = model.SuggestedCourseId ?? 0;
                else if (sender == _btnViewMatchedCourse)
                    courseId = model.MatchedCourseId ?? 0;

                using var form = new CourseForm(courseId);

                form.ShowDialog();
            }
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            SetEvaluation();
        }

        private void _cbEvaluationStatus_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                var evaluation = _evaluations[identifiable.Id];

                evaluation.EvaluationStatus = (EvaluationStatus)_cbEvaluationStatus.SelectedValue;

                if (evaluation.EvaluationStatus == EvaluationStatus.InProcess || evaluation.EvaluationStatus == EvaluationStatus.NotMatched)
                {
                    evaluation.MatchedCourseId = null;
                    evaluation.MatchedCourse   = null;

                    _cbMatchedCourses.SelectedValueChanged -= _cbMatchedCourses_SelectedValueChanged;

                    _cbMatchedCourses.SelectedValue = -1;

                    _cbMatchedCourses.SelectedValueChanged += _cbMatchedCourses_SelectedValueChanged;
                }

                SetData();
                SetEvaluationStatuses();
            }
        }

        private void _cbMatchedCourses_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                var evaluation = _evaluations[identifiable.Id];

                var matchedCourseId = Convert.ToInt32(_cbMatchedCourses.SelectedValue);
                if (matchedCourseId > 0)
                {
                    evaluation.EvaluationStatus = EvaluationStatus.Matched;
                    evaluation.MatchedCourseId  = matchedCourseId;
                    evaluation.MatchedCourse    = _courses[matchedCourseId];

                    _btnViewMatchedCourse.Enabled = true;
                }
                else
                {
                    evaluation.EvaluationStatus = EvaluationStatus.NotMatched;
                    evaluation.MatchedCourseId  = null;
                    evaluation.MatchedCourse    = null;

                    _btnViewMatchedCourse.Enabled = false;
                }

                SetData();
                SetEvaluationStatuses();
            }
        }

        private void _tbComment_TextChanged(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable && _evaluations.ContainsKey(identifiable.Id))
            {
                var evaluation = _evaluations[identifiable.Id];

                evaluation.Comment = _tbComment.Text.Trim();

                SetData();
            }
        }

        private async void _btnSendEmail_Click(object? sender, EventArgs e)
        {
            await InteropActions.SendEmail(this, _application.ApplicationId);
        }

        private async void _btnExportExcel_Click(object? sender, EventArgs e)
        {
            await InteropActions.ExportExcel(this, _application.ApplicationId);
        }

        private void _btnSave_Click(object? sender, EventArgs e)
        {
            if (_application.ApplicationStatus == ApplicationStatus.InProcess)
            {
                var complete = false;

                if (!_application.Evaluations.Any(e => e.EvaluationStatus == EvaluationStatus.InProcess))
                {
                    using var confirmBox = new ConfirmBox(
                        "Do you want to complete application?",
                        $"Application is ready for completion, complete (application will become read-only)?");

                    if (confirmBox.ShowDialog() == DialogResult.OK)
                    {
                        complete = true;
                    }
                }

                using var dc = new Dc();
                using var tr = dc.BeginTransaction();

                if (complete)
                {
                    dc.Applications.Update(
                        a => a.ApplicationId == _application.ApplicationId, 
                        a => new DalApplication { ApplicationStatus = ApplicationStatus.Completed, CompletedAt = DateTime.UtcNow });
                }

                var evaluations = _application.Evaluations.Where(e => e.LinkedEvaluation == null);

                foreach (var evaluation in evaluations)
                    dc.Update(evaluation);

                tr.Commit();
            }

            DialogResult = DialogResult.OK;

            Close();
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
