using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.ViewModels.Organizations;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Forms.Organizations;
using TransferLogger.Ui.Utils;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class OrganizationControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild _appBuild;

        private readonly List<Lookup> _countries = EnumUtils.GetLookups<Country>();

        public OrganizationControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetData();
            SetEvents();
        }

        public void Activate()
        {
            BringToFront();
        }

        private void SetData()
        {
            if (_cbOrganizationTypes.Items.Count == 0)
                _cbOrganizationTypes.FillLookups<OrganizationType>();

            if (_cbCountries.Items.Count == 0)
                _cbCountries.FillLookups(_countries);

            var selectedIds = new HashSet<int> { _appBuild.OrganizationId };

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = SelectableOrganizationViewModel.GetList(selectedIds,
                _tbSearchName.Text, 
                _cbOrganizationTypes.SelectedValue, 
                _cbCountries.SelectedValue);

            if (_appBuild.OrganizationId > 0)
                _grid.SelectRow<IIdentifiable>(i => i.Id == _appBuild.OrganizationId);

            _grid.SelectionChanged += _grid_SelectionChanged;
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged                 += (s, e) => SetData();
            _cbOrganizationTypes.SelectedValueChanged += (s, e) => SetData();
            _cbCountries.SelectedValueChanged         += (s, e) => SetData();

            _grid.CellClick       += (s, e) => SetCurrentRowAsSelected();
            _grid.CellDoubleClick += (s, e) => SetCurrentRowAsSelected();

            _btnAdd.Click           += _btnAdd_Click;
            _btnManage.Click        += _btnManage_Click;
            _btnSelectCountry.Click += _btnSelectCountry_Click;
        }

        private void UpdateSelectedRow()
        {
            if (_grid.DataSource is List<SelectableOrganizationViewModel> organizations)
            {
                foreach (var organization in organizations)
                {
                    organization.Selected = organization.Id == _appBuild.OrganizationId;
                }

                _grid.Refresh();
            }
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateSelectedRow();
        }

        private void SetCurrentRowAsSelected()
        {
            if (_grid.CurrentRow?.DataBoundItem is SelectableOrganizationViewModel viewModel)
            {
                viewModel.Selected = !viewModel.Selected;

                _appBuild.OrganizationId = viewModel.Selected ? viewModel.Id : 0;

                UpdateSelectedRow();
            }
        }

        private (OrganizationType? organizationType, Country? country) GetSelectedValues()
        {
            OrganizationType? organizationType = null;
            if (_cbOrganizationTypes.SelectedValue != null)
                organizationType = (OrganizationType)_cbOrganizationTypes.SelectedValue;

            Country? country = null;
            if (_cbCountries.SelectedValue != null)
                country = (Country)_cbCountries.SelectedValue;

            return (organizationType, country);
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            var (organizationType, country) = GetSelectedValues();

            if (FormUtils.InsertOrReplace(_grid, id => new OrganizationForm(id, organizationType, country), () => SetData(), true))
                SetCurrentRowAsSelected();
        }

        private void _btnManage_Click(object? sender, EventArgs e)
        {
            var (organizationType, country) = GetSelectedValues();

            using var form = new OrganizationsForm(organizationType, country);

            form.ShowDialog();

            // Check if current selection was deleted.
            using var dc = new Dc();

            if (!dc.Organizations.Any(o => o.OrganizationId == _appBuild.OrganizationId))
                _appBuild.OrganizationId = 0;

            SetData();
        }

        private void _btnSelectCountry_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Country", _countries, _cbCountries.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbCountries.SelectedValue = form.SelectedValue.Value;
            }
        }

        public bool Complete()
        {
            if (_appBuild.OrganizationId <= 0)
            {
                MessageDialog.Show("You have to select organization.");

                return false;
            }
            else
            {
                // Remove any courses which do not belong to current organization selection.
                // This might occur if user selected organization, courses and then stepped back and changed organization.
                if (_appBuild.Evaluations.Any())
                {
                    using var dc = new Dc();

                    var courseIds = _appBuild.CourseIds;

                    var organizationCourseIds = dc.Courses
                        .Where(c => c.OrganizationId == _appBuild.OrganizationId)
                        .Select(c => c.CourseId)
                        .ToHashSet();

                    foreach (var courseId in courseIds)
                    {
                        if (organizationCourseIds.Contains(courseId))
                        {
                            _appBuild.Evaluations.Remove(courseId);
                        }
                    }
                }

                return true;
            }
        }
    }
}
