using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Settings;
using TransferLogger.BusinessLogic.Models.Programs;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Forms.Programs;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class ProgramControl : UserControl, IWizardControl
    {
        private BindingList<SelectableProgramModel> _programs = new();

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

        private void SetData(bool refresh = false, int? index = null)
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

            index ??= _grid.CurrentRow?.Index;

            var selectedIds = new HashSet<int>();

            if (_programs.SingleOrDefault(i => i.Selected) is IIdentifiable identifiable)
                selectedIds.Add(identifiable.Id);

            var programs = SelectableProgramModel.GetList(
                selectedIds,
                _tbSearchName.Text,
                AppSettings.Instance.OrganizationId,
                _cbCycles.GetSelectedValue<Cycle>());

            _programs = new BindingList<SelectableProgramModel>(programs);

            _grid.DataSource = _programs;

            _grid.SelectRow(index);
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged += (s, e) => SetData();
            _grid.CellClick           += (s, e) => SetCurrentRowAsSelected();
            _grid.CellDoubleClick     += (s, e) => SetCurrentRowAsSelected();

            _btnAdd.Click    += _btnAdd_Click;
            _btnManage.Click += _btnManage_Click;
            _grid.KeyDown    += _grid_KeyDown;
        }

        private void _cbCycles_SelectedValueChanged(object? sender, EventArgs e)
        {
            SetData();
        }

        private void SetCurrentRowAsSelected()
        {
            if (_grid.CurrentRow?.DataBoundItem is SelectableProgramModel program)
                program.Selected = !program.Selected;
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new ProgramForm(
                0,
                AppSettings.Instance.OrganizationId,
                true,
                _cbCycles.GetSelectedValue<Cycle>());

            if (form.ShowDialog() == DialogResult.OK)
            {
                SetData(index: _grid.RowCount + 1);
                SetCurrentRowAsSelected();
            }
        }

        private void _btnManage_Click(object? sender, EventArgs e)
        {
            var cycle = _cbCycles.GetSelectedValue<Cycle>();

            using var form = new ProgramsForm(AppSettings.Instance.OrganizationId, cycle);

            form.ShowDialog();

            SetData();
        }

        private void _grid_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SetCurrentRowAsSelected();

                e.SuppressKeyPress = true;
            }
        }

        public bool Complete()
        {
            if (_programs.SingleOrDefault(i => i.Selected) is not IIdentifiable identifiable)
            {
                MessageDialog.Show("You have to select program.", "Wizard Validation");

                return false;
            }
            else
            {
                _appBuild.TargetProgramId = identifiable.Id;
                _appBuild.CleanObsoleteResources();

                return true;
            }
        }
    }
}
