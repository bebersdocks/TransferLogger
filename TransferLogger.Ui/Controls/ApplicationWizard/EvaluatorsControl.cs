using System;
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

        public EvaluatorsControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetEvents();
        }

        public void Activate()
        {
            // On each activate - refresh lookup lists to reflect changes inside db (if any in previous steps).
            if (_grid.Columns.Count == 3)
            {
                _grid.Columns.RemoveAt(1);
                _grid.Columns.RemoveAt(1);
            }

            _grid.Columns.Add(GetInstructorsColumn());
            _grid.Columns.Add(GetSuggestedCoursesColumn());

            SetData();

            BringToFront();
        }
        
        private static DataGridViewComboBoxColumn GetComboBoxColumn()
        {
            return new DataGridViewComboBoxColumn
            {
                DisplayMember = "DisplayName",
                FillWeight    = 105,
                FlatStyle     = FlatStyle.Popup,
                MinimumWidth  = 225,
                ValueMember   = "Value",
                ReadOnly      = false,
            };
        }

        private DataGridViewComboBoxColumn GetInstructorsColumn()
        {
            var column = GetComboBoxColumn();

            var instructors = LookupServices.GetInstructors();

            instructors.Insert(0, new Lookup(0, "Not assigned"));

            column.DataSource       = instructors;
            column.DataPropertyName = nameof(BuildEvaluationViewModel.InstructorId);
            column.HeaderText       = "Evaluator";
            column.Name             = "Instructor";
        
            return column;
        }

        private DataGridViewComboBoxColumn GetSuggestedCoursesColumn()
        {
            var column = GetComboBoxColumn();

            var suggestedCourses = LookupServices.GetCourses(AppSettings.Instance.OrganizationId);

            suggestedCourses.Insert(0, new Lookup(0, "None"));

            column.DataSource       = suggestedCourses;
            column.DataPropertyName = nameof(BuildEvaluationViewModel.SuggestedCourseId);
            column.HeaderText       = "Suggested Course";
            column.Name             = "SuggestedCourse";

            return column;
        }

        private void SetData()
        {
            _cbEvaluators.SelectedValueChanged       -= OnValuesChanges;
            _cbSuggestedCourses.SelectedValueChanged -= OnValuesChanges;

            _cbEvaluators.FillLookups(LookupServices.GetInstructors());
            _cbSuggestedCourses.FillLookups(LookupServices.GetCourses(AppSettings.Instance.OrganizationId));

            _cbEvaluators.SelectedValueChanged       += OnValuesChanges;
            _cbSuggestedCourses.SelectedValueChanged += OnValuesChanges;

            if (_currentCourseId <= 0 && !_appBuild.Evaluations.ContainsKey(_currentCourseId))
                _currentCourseId = _appBuild.CourseIds.FirstOrDefault();

            using var dc = new Dc();

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = _appBuild.Evaluations.Values
                .Where(e => e.HistoricalEvaluationId <= 0)
                .Select(e => new BuildEvaluationViewModel(dc, e))
                .ToList();

            _grid.SelectRow<BuildEvaluationViewModel>(i => i.CourseId == _currentCourseId);

            _grid.SelectionChanged += _grid_SelectionChanged;

            UpdateValues();
        }

        private void SetEvents()
        {
            _btnSelectEvaluator.Click       += _btnSelectEvaluator_Click;
            _btnSelectSuggestedCourse.Click += _btnSelectSuggestedCourse_Click;

            _grid.CurrentCellDirtyStateChanged += _grid_CurrentCellDirtyStateChanged;
        }

        // Updates values of both plain and grid drop down lists (synchronization).
        private void UpdateValues()
        {
            if (_appBuild.Evaluations.TryGetValue(_currentCourseId, out var evaluation) && _grid.CurrentRow?.DataBoundItem is BuildEvaluationViewModel viewModel)
            {
                _cbEvaluators.SelectedValueChanged       -= OnValuesChanges;
                _cbSuggestedCourses.SelectedValueChanged -= OnValuesChanges;

                _cbEvaluators.SelectedValue       = evaluation.InstructorId;
                _cbSuggestedCourses.SelectedValue = evaluation.SuggestedCourseId;

                viewModel.InstructorId      = evaluation.InstructorId;
                viewModel.SuggestedCourseId = evaluation.SuggestedCourseId;

                _grid.Refresh();

                _cbEvaluators.SelectedValueChanged       += OnValuesChanges;
                _cbSuggestedCourses.SelectedValueChanged += OnValuesChanges;
            }
        }


        private void _grid_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            _grid.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if (_grid.CurrentRow?.DataBoundItem is BuildEvaluationViewModel viewModel)
            {
                var evaluation = _appBuild.Evaluations[_currentCourseId];

                evaluation.InstructorId = viewModel.InstructorId;
                evaluation.SuggestedCourseId = viewModel.SuggestedCourseId;
            }

            UpdateValues();
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is BuildEvaluationViewModel viewModel)
            {
                _currentCourseId = viewModel.CourseId;
            }

            UpdateValues();
        }

        private void OnValuesChanges(object? sender, EventArgs e)
        {
            var evaluation = _appBuild.Evaluations[_currentCourseId];

            evaluation.InstructorId      = Convert.ToInt32(_cbEvaluators.SelectedValue);
            evaluation.SuggestedCourseId = Convert.ToInt32(_cbSuggestedCourses.SelectedValue);

            UpdateValues();
        }

        private void _btnSelectEvaluator_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Evaluator", LookupServices.GetInstructors(), _cbEvaluators.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbEvaluators.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnSelectSuggestedCourse_Click(object? sender, EventArgs e)
        {
            var suggestedCourses = LookupServices.GetCourses(AppSettings.Instance.OrganizationId);

            using var form = new LookupSelectionForm("Select Suggested Course", suggestedCourses, _cbSuggestedCourses.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbSuggestedCourses.SelectedValue = form.SelectedValue.Value;
            }
        }

        public bool Complete()
        {
            if (_appBuild.Evaluations.Values.Any(e => e.InstructorId <= 0 && e.HistoricalEvaluationId <= 0))
            {
                MessageDialog.Show("You have to assign evaluator for each course.");

                return false;
            }

            return true;
        }
    }
}
