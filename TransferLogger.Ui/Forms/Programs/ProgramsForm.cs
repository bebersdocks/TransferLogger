using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Models.Programs;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Programs
{
    public partial class ProgramsForm : Form
    {
        private readonly List<Lookup> _organizations = LookupServices.GetOrganizations();

        public ProgramsForm() : this(0, Dal.Definitions.Cycle.Bachelor) { }

        public ProgramsForm(int? organizationId = null, Cycle? cycle = null)
        {
            InitializeComponent();

            SetData(organizationId, cycle);
            SetEvents();
        }

        private void SetData(int? organizationId = null, Cycle? cycle = null, int? index = null)
        {
            index ??= _grid.CurrentRow?.Index;

            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations, organizationId);

            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups(cycle ?? Dal.Definitions.Cycle.Bachelor);

            _grid.DataSource = ProgramModel.GetList(
                _tbSearchName.Text,
                Convert.ToInt32(_cbOrganizations.SelectedValue), 
                _cbCycles.GetSelectedValue<Cycle>());

            _grid.SelectRow(index);
        }

        private void SetEvents()
        {
            _tbSearchName.TextChanged             += (s, e) => SetData();
            _cbCycles.SelectedValueChanged        += (s, e) => SetData();
            _cbOrganizations.SelectedValueChanged += (s, e) => SetData();

            _btnAdd.Click                += _btnAdd_Click;
            _btnEdit.Click               += _btnEdit_Click;
            _btnDelete.Click             += _btnDelete_Click;
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;
            _grid.DoubleClick            += _btnEdit_Click;
        }

        private void _btnSelectOrganization_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Organization", _organizations, _cbOrganizations.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbOrganizations.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new ProgramForm(
                0,
                Convert.ToInt32(_cbOrganizations.SelectedValue),
                false,
                _cbCycles.GetSelectedValue<Cycle>());

            if (form.ShowDialog() == DialogResult.OK)
                SetData(index: _grid.RowCount + 1);
        }

        private void _btnEdit_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                using var form = new ProgramForm(
                    identifiable.Id,
                    Convert.ToInt32(_cbOrganizations.SelectedValue),
                    false,
                    _cbCycles.GetSelectedValue<Cycle>());


                if (form.ShowDialog() == DialogResult.OK)
                    SetData();
            }
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is ProgramModel program)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {program.Name} [{program.Cycle}] (Id: {program.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    using var dc = new Dc();

                    dc.Programs
                        .Where(p => p.ProgramId == program.Id)
                        .Delete();

                    SetData();
                }
            }
        }
    }
}
