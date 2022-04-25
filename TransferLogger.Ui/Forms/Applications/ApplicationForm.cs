using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Utils;

using DalApplication = TransferLogger.Dal.DataModels.Applications.Application;

namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ApplicationForm : Form
    {
        private int _currentEvaluationId = 0;

        private readonly DalApplication _application;
        private readonly List<Lookup>   _courses;
        private readonly bool           _readOnly;

        public ApplicationForm(int appId, bool readOnly = false)
        {
            InitializeComponent();

            using var dc = new Dc();

            _application = dc.GetApplication(appId);
            _courses     = LookupServices.GetCourses(_application.TargetOrganizationId, _application.TargetProgramId);
            _readOnly    = readOnly;

            _pnlApplicationDetails.Enabled = !readOnly;

            Text = $"Transfer application for {_application.Student.DisplayString} (Id: {_application.ApplicationId})";

            SetData(true);
            SetEvents();
        }

        private void SetData(bool initial = false)
        {
            if (_currentEvaluationId <= 0)
                _currentEvaluationId = _application.Evaluations.First().EvaluationId;

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = _application.Evaluations
                .Select(e => new EvaluationViewModel(e, _application))
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

                SetEvaluation();
            }
        }

        private void SetEvaluation()
        {
            _pnlEvaluation.Enabled = !_readOnly || _application.ApplicationStatus == ApplicationStatus.InProcess;

            if (_grid.CurrentRow?.DataBoundItem is EvaluationViewModel viewModel)
            {
                _currentEvaluationId = viewModel.Id;

                _tbCourse.Text          = viewModel.Course;
                _tbSuggestedCourse.Text = viewModel.SuggestedCourse;
                _tbEvaluator.Text       = viewModel.Instructor;
                _tbComment.Text         = viewModel.Comment;

                _cbMatchedCourses.FillLookups(_courses, viewModel.MatchedCourseId);

                _btnViewSuggestedCourse.Enabled = (viewModel.SuggestedCourseId ?? 0) > 0;
                _btnViewMatchedCourse.Enabled   = (viewModel.MatchedCourseId ?? 0) > 0;

                if (_pnlEvaluation.Enabled)
                {
                    bool readOnly = viewModel.Status == EvaluationStatus.MatchedByHistory;

                    _cbMatchedCourses.Enabled = !readOnly;

                    FormUtils.SetReadOnly(_tbComment, readOnly);
                }
            }
        }

        private void SetEvents()
        {
            _btnViewCourse.Click          += ViewCourse;
            _btnViewSuggestedCourse.Click += ViewCourse;
            _btnViewMatchedCourse.Click   += ViewCourse;

            _cbMatchedCourses.SelectedValueChanged += _cbMatchedCourses_SelectedValueChanged;
            _tbComment.TextChanged                 += _tbComment_TextChanged;

            _btnSendEmail.Click   += _btnSendEmail_Click;
            _btnExportExcel.Click += _btnExportExcel_Click;
            _btnSave.Click        += _btnSave_Click;
            _btnCancel.Click      += _btnCancel_Click;
        }

        private void ViewCourse(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is EvaluationViewModel viewModel)
            {
                int courseId = 0;

                if (sender == _btnViewCourse)
                    courseId = viewModel.CourseId;
                if (sender == _btnViewSuggestedCourse)
                    courseId = viewModel.SuggestedCourseId ?? 0;
                else if (sender == _btnViewMatchedCourse)
                    courseId = viewModel.MatchedCourseId ?? 0;

                using var form = new CourseForm(courseId);

                form.ShowDialog();
            }
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            SetEvaluation();
        }

        private Evaluation? GetGridEvaluation()
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                return _application.Evaluations.FirstOrDefault(e => e.EvaluationId == identifiable.Id);
            }

            return null;
        }

        private void _cbMatchedCourses_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (GetGridEvaluation() is Evaluation evaluation)
            {
                evaluation.MatchedCourseId = Convert.ToInt32(_cbMatchedCourses.SelectedValue);

                _btnViewMatchedCourse.Enabled = (evaluation.MatchedCourseId ?? 0) > 0;

                SetData();
            }
        }

        private void _tbComment_TextChanged(object? sender, EventArgs e)
        {
            if (GetGridEvaluation() is Evaluation evaluation)
            {
                evaluation.Comment = _tbComment.Text;

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
            throw new NotImplementedException();
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
