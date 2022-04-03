using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using Serilog;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Utils;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Programs
{
    public partial class ProgramsForm : Form
    {
        private readonly List<Lookup> _organizations = LookupServices.GetOrganizations();

        public ProgramsForm(int? organizationId = null, bool organizationsLocked = false, Cycle? cycle = null)
        {
            InitializeComponent();

            SetData(organizationId, organizationsLocked, cycle);
            SetEvents();
        }

        private void SetData(int? organizationId = null, bool organizationsLocked = false, Cycle? cycle = null)
        {
            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations, organizationId);

            _cbOrganizations.Enabled       = !organizationsLocked;
            _btnSelectOrganization.Enabled = !organizationsLocked;

            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups(cycle ?? Dal.Definitions.Cycle.Bachelor);

            _grid.DataSource = ProgramViewModel.GetList(_tbSearchName.Text, _cbOrganizations.SelectedValue, _cbCycles.SelectedValue);
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged             += (s, e) => SetData();
            _cbCycles.SelectedValueChanged        += (s, e) => SetData();
            _cbOrganizations.SelectedValueChanged += (s, e) => SetData();

            _btnSelectOrganization.Click += _btnSelectOrganization_Click;

            _grid.DoubleClick += (s, e) => InsertOrReplace();
            _btnAdd.Click     += (s, e) => InsertOrReplace(true);
            _btnEdit.Click    += (s, e) => InsertOrReplace();

            _btnDelete.Click += _btnDelete_Click;
        }

        private void _btnSelectOrganization_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Organization", _organizations, _cbOrganizations.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbOrganizations.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void InsertOrReplace(bool isNew = false)
        {
            var organizationId      = Convert.ToInt32(_cbOrganizations.SelectedValue);
            var organizationsLocked = !_cbOrganizations.Enabled;

            Cycle? cycle = null;
            if (_cbCycles.SelectedValue != null)
                cycle = (Cycle)_cbCycles.SelectedValue;

            FormUtils.InsertOrReplace(_grid, id => new ProgramForm(id, organizationId, organizationsLocked, cycle), () => SetData(), isNew);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is ProgramViewModel viewModel)
            {
                using var confirmDlg = new ConfirmDialog(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {viewModel.Name} [{viewModel.Cycle}] (Id: {viewModel.Id})?");

                if (confirmDlg.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using var dc = new Dc();

                        dc.Programs
                            .Where(p => p.ProgramId == viewModel.Id)
                            .Delete();

                        SetData();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "failed");

                        ErrorDialog.Show(ex.Message, "Database Error");
                    }
                }
            }
        }
    }
}
