using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

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
        private readonly List<Lookup> _organizations;

        public ProgramsForm()
        {
            InitializeComponent();

            using var dc = new Dc();

            _organizations = dc.Organizations
                .Select(o => new Lookup(o.OrganizationId, o.DisplayString))
                .ToList();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups<Lookup>(_organizations);

            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups<Cycle>();

            using var dc = new Dc();

            var query = dc.Programs.AsQueryable();

            if (!string.IsNullOrEmpty(_tbSearchName.Text))
                query = query.Where(p => p.Name.Contains(_tbSearchName.Text, StringComparison.OrdinalIgnoreCase));

            if (_cbOrganizations.SelectedValue != null)
                query = query.Where(p => p.OrganizationId == (int)_cbOrganizations.SelectedValue);

            if (_cbCycles.SelectedValue != null)
                query = query.Where(p => p.Cycle == (Cycle)_cbCycles.SelectedValue);

            _grid.DataSource = query
                .Select(p => new ProgramViewModel(p, p.Organization))
                .ToList();
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
            FormUtils.InsertOrReplace(_grid, id => new ProgramForm(id), () => SetData(), isNew);
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
                    using var dc = new Dc();

                    dc.Programs
                        .Where(p => p.ProgramId == viewModel.Id)
                        .Delete();

                    SetData();
                }
            }
        }
    }
}
