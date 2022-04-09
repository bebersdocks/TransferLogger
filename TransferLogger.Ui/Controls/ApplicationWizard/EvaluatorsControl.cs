using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Ui.Forms;
using TransferLogger.Ui.Forms.Dialogs;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class EvaluatorsControl : UserControl, IWizardControl
    {
        private int _currentCourseId = 0;

        private readonly ApplicationBuild _appBuild;

        private readonly List<Lookup> _instructors      = LookupServices.GetInstructors();
        private readonly List<Lookup> _suggestedCourses = LookupServices.GetCourses(AppSettings.Instance.OrganizationId);

        public EvaluatorsControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

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
                _currentCourseId = _appBuild.CourseIds.FirstOrDefault();

            if (_cbEvaluators.Items.Count == 0)
                _cbEvaluators.FillLookups(_instructors);

            if (_cbSuggestedCourses.Items.Count == 0)
                _cbSuggestedCourses.FillLookups(_suggestedCourses);

            _grid.SelectionChanged -= _grid_SelectionChanged;

            using var dc = new Dc();

            _grid.DataSource = _appBuild.Evaluations.Values
                .Where(e => e.HistoricalEvaluationId <= 0)
                .Select(e => new ApplicationEvaluationViewModel(dc, e))
                .ToList();

            _grid.SelectRow<ApplicationEvaluationViewModel>(i => i.CourseId == _currentCourseId);

            _grid.SelectionChanged += _grid_SelectionChanged;

            SetControls();
        }

        private void SetEvents()
        {
            _btnSelectEvaluator.Click       += _btnSelectEvaluator_Click;
            _btnSelectSuggestedCourse.Click += _btnSelectSuggestedCourse_Click;
        }

        private void SetControls()
        {
            if (_grid.CurrentRow?.DataBoundItem is ApplicationEvaluationViewModel viewModel)
            {
                _currentCourseId = viewModel.CourseId;
            }

            if (_appBuild.Evaluations.TryGetValue(_currentCourseId, out var evaluation))
            {
                _cbEvaluators.SelectedValueChanged       -= OnValuesChanges;
                _cbSuggestedCourses.SelectedValueChanged -= OnValuesChanges;

                _cbEvaluators.SelectedValue       = evaluation.InstructorId;
                _cbSuggestedCourses.SelectedValue = Convert.ToInt32(evaluation.SuggestedCourseId);

                _cbEvaluators.SelectedValueChanged       += OnValuesChanges;
                _cbSuggestedCourses.SelectedValueChanged += OnValuesChanges;
            }
        }

        private void OnValuesChanges(object? sender, EventArgs e)
        {
            var evaluation = _appBuild.Evaluations[_currentCourseId];

            if (sender == _cbEvaluators)
                evaluation.InstructorId = Convert.ToInt32(_cbEvaluators.SelectedValue);
            else if (sender == _cbSuggestedCourses)
                evaluation.SuggestedCourseId = Convert.ToInt32(_cbSuggestedCourses.SelectedValue);

            SetData();
        }

        private void _btnSelectEvaluator_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Evaluator", _instructors, _cbEvaluators.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbEvaluators.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnSelectSuggestedCourse_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Suggested Course", _suggestedCourses, _cbSuggestedCourses.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbSuggestedCourses.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            SetControls();
        }

        public bool Complete()
        {
            if (_appBuild.Evaluations.Values.Any(e => e.InstructorId <= 0 && e.HistoricalEvaluationId <= 0))
            {
                MessageDialog.Show("You have to assign evaluators for each course.");

                return false;
            }

            return true;
        }
    }
}
