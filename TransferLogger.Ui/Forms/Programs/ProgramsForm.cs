using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Models.Programs;
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

        public ProgramsForm() : this(0, Dal.Definitions.Cycle.Bachelor) {}

        public ProgramsForm(int? organizationId = null, Cycle? cycle = null)
        {
            InitializeComponent();

            SetData(organizationId, cycle);
            SetEvents();
        }

        private void SetData(int? organizationId = null, Cycle? cycle = null)
        {
            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations, organizationId);

            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups(cycle ?? Dal.Definitions.Cycle.Bachelor);

            _grid.DataSource = ProgramModel.GetList(_tbSearchName.Text, _cbOrganizations.SelectedValue, _cbCycles.SelectedValue);
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
            var organizationId = Convert.ToInt32(_cbOrganizations.SelectedValue);

            Cycle? cycle = null;
            if (_cbCycles.SelectedValue != null)
                cycle = (Cycle)_cbCycles.SelectedValue;

            FormUtils.InsertOrReplace(_grid, id => new ProgramForm(id, organizationId, false, cycle), () => SetData(), isNew);
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is ProgramModel model)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {model.Name} [{model.Cycle}] (Id: {model.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    var index = _grid.CurrentRow.Index;

                    using var dc = new Dc();

                    dc.Programs
                        .Where(p => p.ProgramId == model.Id)
                        .Delete();

                    SetData();

                    _grid.SelectRow(index);
                }
            }
        }
    }
}
