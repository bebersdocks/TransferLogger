using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.ViewModels.Programs;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;
using TransferLogger.Ui.Forms.Programs;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class ProgramControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild _appBuild;

        public ProgramControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetEvents();
        }

        public void Activate()
        {
            SetData(true);

            BringToFront();

            _grid.Focus();
        }

        private void SetData(bool refresh = false)
        {
            if (refresh)
            {
                var cycle = Dal.Definitions.Cycle.Bachelor;

                if (_appBuild.TargetProgramId > 0)
                {
                    using var dc = new Dc();

                    cycle = dc.Programs.First(p => p.ProgramId == _appBuild.TargetProgramId)
                        .Cycle;
                }

                _cbCycles.SelectedValueChanged -= _cbCycles_SelectedValueChanged;

                _cbCycles.FillLookups(cycle);

                _cbCycles.SelectedValueChanged += _cbCycles_SelectedValueChanged;
            }

            var selectedIds = new HashSet<int> { _appBuild.TargetProgramId };

            _grid.SelectionChanged -= _grid_SelectionChanged;

            _grid.DataSource = SelectableProgramViewModel.GetList(selectedIds,
                _tbSearchName.Text, 
                AppSettings.Instance.OrganizationId,
                _cbCycles.SelectedValue);

            if (_appBuild.TargetProgramId > 0)
                _grid.SelectRow<IIdentifiable>(i => i.Id == _appBuild.TargetProgramId);

            _grid.SelectionChanged += _grid_SelectionChanged;
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged += (s, e) => SetData();

            _grid.CellClick       += (s, e) => SetCurrentRowAsSelected();
            _grid.CellDoubleClick += (s, e) => SetCurrentRowAsSelected();

            _grid.KeyDown += _grid_KeyDown;

            _btnAdd.Click    += _btnAdd_Click;
            _btnManage.Click += _btnManage_Click;
        }

        private void _cbCycles_SelectedValueChanged(object? sender, EventArgs e)
        {
            SetData();
        }

        private void UpdateSelectedRow()
        {
            if (_grid.DataSource is List<SelectableProgramViewModel> programs)
            {
                foreach (var program in programs)
                {
                    program.Selected = program.Id == _appBuild.TargetProgramId;
                }

                _grid.Refresh();
            }
        }

        private void _grid_SelectionChanged(object? sender, EventArgs e)
        {
            UpdateSelectedRow();
        }

        private void _grid_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCurrentRowAsSelected();

                e.SuppressKeyPress = true;
            }
        }

        private void SetCurrentRowAsSelected()
        {
            if (_grid.CurrentRow?.DataBoundItem is SelectableProgramViewModel viewModel)
            {
                viewModel.Selected = !viewModel.Selected;

                _appBuild.TargetProgramId = viewModel.Selected ? viewModel.Id : 0;

                UpdateSelectedRow();
            }
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            var cycle = (Cycle)_cbCycles.SelectedValue;

            if (FormUtils.InsertOrReplace(_grid, id => new ProgramForm(id, AppSettings.Instance.OrganizationId, true, cycle), () => SetData(), true))
                SetCurrentRowAsSelected();
        }

        private void _btnManage_Click(object? sender, EventArgs e)
        {
            var cycle = (Cycle)_cbCycles.SelectedValue;

            using var form = new ProgramsForm(AppSettings.Instance.OrganizationId, cycle);

            form.ShowDialog();

            using var dc = new Dc();

            if (!dc.Programs.Any(p => p.ProgramId == _appBuild.TargetProgramId))
                _appBuild.TargetProgramId = 0;

            SetData();
        }

        public bool Complete()
        {
            if (_appBuild.TargetProgramId <= 0)
            {
                MessageDialog.Show("You have to select program.", "Wizard Validation");

                return false;
            }
            else
            {
                _appBuild.CleanObsoleteResources();

                return true;
            }
        }
    }
}
