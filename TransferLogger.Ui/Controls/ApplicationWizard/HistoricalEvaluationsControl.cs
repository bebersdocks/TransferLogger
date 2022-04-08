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
        public void Activate()
        {
            SetData();

            BringToFront();
        }

        private void SetData()
        {
            if (_currentCourseId <= 0 && !_appBuild.Evaluations.ContainsKey(_currentCourseId))
                _currentCourseId = _appBuild.Evaluations.Keys.FirstOrDefault();

            if (_currentCourseId > 0)
            {
                var evaluation = _appBuild.Evaluations[_currentCourseId];

                _cbUseHistoricalEvaluation.Checked = evaluation.HistoricalEvaluationId > 0;

                using var dc = new Dc();

                var courses = dc.Courses
                    .Where(c => _appBuild.Evaluations.ContainsKey(c.CourseId))
                    .Where(c => c.Evaluations.Any())
                    .Select(c => new Lookup(c.CourseId, c.DisplayString))
                    .ToList();

                if (_cbStatuses.Items.Count == 0)
                    _cbStatuses.FillLookups<EvaluationStatus>();

                _cbCourses.SelectedValueChanged -= _cbCourses_SelectedValueChanged;

                _cbCourses.FillLookups(courses);

                _cbCourses.SelectedValue = _currentCourseId;

                _cbCourses.SelectedValueChanged += _cbCourses_SelectedValueChanged;

                _grid.SelectionChanged -= _grid_SelectionChanged;

                _grid.DataSource = EvaluationViewModel.GetHistoricalEvaluations(_currentCourseId);

                if (evaluation.HistoricalEvaluationId > 0)
                    _grid.SelectRow<IIdentifiable>(i => i.Id == evaluation.HistoricalEvaluationId);

                _grid.SelectionChanged += _grid_SelectionChanged;

                SetControls();
            }
        }

        private void SetControls()
        {
            _pnlEvaluation.Enabled = _cbUseHistoricalEvaluation.Checked;

            if (!_cbUseHistoricalEvaluation.Checked)
            {
                _appBuild.Evaluations[_currentCourseId].HistoricalEvaluationId = 0;
            }

            if (_grid.CurrentRow?.DataBoundItem is EvaluationViewModel viewModel)
            {
                if (_cbUseHistoricalEvaluation.Checked)
                {
                    _appBuild.Evaluations[_currentCourseId].HistoricalEvaluationId = viewModel.Id;
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
            _cbUseHistoricalEvaluation.CheckedChanged += (s, e) => SetControls();
        }

        private void _cbCourses_SelectedValueChanged(object? sender, EventArgs e)
        {
            _currentCourseId = Convert.ToInt32(_cbCourses.SelectedValue);

            SetData();
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            SetControls();
        }

        public bool Complete()
        {
            return true;
        }
    }
}
