using System;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class HistoricalEvaluationsControl : UserControl, IWizardControl
    {
        private int _currentCourseId = 0;

        private readonly ApplicationBuild _appBuild;

        public HistoricalEvaluationsControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            using var dc = new Dc();

            var courses = dc.Courses
                .Where(c => _appBuild.CourseIds.Contains(c.CourseId))
                .Where(c => c.Evaluations.Any())
                .Select(c => new Lookup(c.CourseId, c.DisplayString))
                .ToList();

            if (_currentCourseId <= 0 && !_appBuild.CourseIds.Contains(_currentCourseId))
                _currentCourseId = _appBuild.CourseIds.FirstOrDefault();

            _cbUseHistoricalEvaluation.Checked = _appBuild.HistoricalEvaluations.ContainsKey(_currentCourseId);

            _cbCourses.SelectedValueChanged -= _cbCourses_SelectedValueChanged;

            _cbCourses.FillLookups(courses);

            _cbCourses.SelectedValue = _currentCourseId;

            _cbCourses.SelectedValueChanged += _cbCourses_SelectedValueChanged;

            if (_cbStatuses.Items.Count == 0)
                _cbStatuses.FillLookups<EvaluationStatus>();

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = EvaluationViewModel.GetHistoricalEvaluations(_currentCourseId);

            if (_appBuild.HistoricalEvaluations.TryGetValue(_currentCourseId, out var evaluationId))
                _grid.SelectRow<IIdentifiable>(i => i.Id == evaluationId);

            _grid.SelectionChanged += _grid_SelectionChanged;

            SetEvaluationControls();
        }

        private void SetEvaluationControls()
        {
            _pnlEvaluation.Enabled = _cbUseHistoricalEvaluation.Checked;

            if (!_cbUseHistoricalEvaluation.Checked)
            {
                _appBuild.HistoricalEvaluations.Remove(_currentCourseId);
            }

            if (_grid.CurrentRow?.DataBoundItem is EvaluationViewModel viewModel)
            {
                if (_cbUseHistoricalEvaluation.Checked)
                {
                    _appBuild.HistoricalEvaluations[_currentCourseId] = viewModel.Id;
                }

                _tbEvaluationCourse.Text = viewModel.Course;
                _tbMatchedCourse.Text    = viewModel.MatchedCourse;
                _tbApplicationDt.Text    = viewModel.ApplicationDt.ToString("dd/MM/yyyy HH:mm:ss");
                _tbOrganization.Text     = viewModel.Organization;
                _tbStudent.Text          = viewModel.Student;
                _tbEvaluator.Text        = viewModel.Instructor;
                _tbComment.Text          = viewModel.Comment;

                _cbStatuses.SelectedValue = Convert.ToInt32(viewModel.Status);
            }
            else
            {
                _tbEvaluationCourse.Text  = "";
                _tbMatchedCourse.Text     = "";
                _tbApplicationDt.Text     = "";
                _tbOrganization.Text      = "";
                _tbStudent.Text           = "";
                _tbEvaluator.Text         = "";
                _tbComment.Text           = "";

                _cbStatuses.SelectedIndex = -1;
            }
        }

        private void SetEvents()
        {
            _cbUseHistoricalEvaluation.CheckedChanged += (s, e) => SetEvaluationControls();
        }

        private void _cbCourses_SelectedValueChanged(object? sender, EventArgs e)
        {
            _currentCourseId = Convert.ToInt32(_cbCourses.SelectedValue);

            SetData();
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            SetEvaluationControls();
        }

        public void Activate()
        {
            SetData();

            BringToFront();
        }
 
        public bool Complete()
        {
            return true;
        }
    }
}
