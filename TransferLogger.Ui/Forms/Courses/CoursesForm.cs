using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Models.Courses;
using TransferLogger.Dal;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Courses
{
    public partial class CoursesForm : Form
    {
        private readonly List<Lookup> _organizations = LookupServices.GetOrganizations();

        public CoursesForm() : this(0, Dal.Definitions.Cycle.Bachelor) { }

        public CoursesForm(int? organizationId = null, Cycle? cycle = null)
        {
            InitializeComponent();

            SetData(organizationId, cycle);
            SetPrograms();
            SetEvents();
        }

        private void SetData(int? organizationId = null, Cycle? cycle = null, int? index = null)
        {
            index ??= _grid.CurrentRow?.Index;

            if (_cbOrganizations.Items.Count == 0)
                _cbOrganizations.FillLookups(_organizations, organizationId);

            if (_cbCycles.Items.Count == 0)
                _cbCycles.FillLookups<Cycle>(Convert.ToInt32(cycle));

            _grid.DataSource = CourseModel.GetList(
                _tbSearchName.Text,
                Convert.ToInt32(_cbOrganizations.SelectedValue),
                _cbCycles.GetSelectedValue<Cycle>(),
                Convert.ToInt32(_cbPrograms.SelectedValue));

            if (index.HasValue)
                _grid.SelectRow(index.Value);
        }

        private void SetPrograms()
        {
            var programs = LookupServices.GetPrograms(_cbOrganizations.SelectedValue, _cbCycles.SelectedValue);

            if (programs.Any())
            {
                _btnSelectProgram.Enabled = true;
                _cbPrograms.Enabled       = true;

                _cbPrograms.FillLookups(programs, (int?)_cbPrograms.SelectedValue ?? -1);
            }
            else
            {
                _btnSelectProgram.Enabled = false;
                _cbPrograms.Enabled       = false;
                _cbPrograms.DataSource    = null;
            }
        }

        private void SetEvents()
        {
            _cbPrograms.SelectedValueChanged += (s, e) => SetData();

            _tbSearchName.TextChanged             += FiltersChanged;
            _cbOrganizations.SelectedValueChanged += FiltersChanged;
            _cbCycles.SelectedValueChanged        += FiltersChanged;

            _btnAdd.Click                += _btnAdd_Click;
            _btnEdit.Click               += _btnEdit_Click;
            _btnDelete.Click             += _btnDelete_Click;
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;
            _btnSelectProgram.Click      += _btnSelectProgram_Click;
            _grid.DoubleClick            += _btnEdit_Click;
        }

        private void FiltersChanged(object? sender, EventArgs e)
        {
            SetData();
            SetPrograms();
        }

        private void _btnSelectOrganization_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm(
                "Select Organization", 
                _organizations, 
                _cbOrganizations.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
                _cbOrganizations.SelectedValue = form.SelectedValue.Value;
        }

        private void _btnSelectProgram_Click(object? sender, EventArgs e)
        {
            var programs = LookupServices.GetPrograms(_cbOrganizations.SelectedValue, _cbCycles.SelectedValue);

            using var form = new LookupSelectionForm(
                "Select Program", 
                programs, 
                _cbPrograms.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
                _cbPrograms.SelectedValue = form.SelectedValue.Value;
        }

        private void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var form = new CourseForm(
                0,
                Convert.ToInt32(_cbOrganizations.SelectedValue),
                false,
                Convert.ToInt32(_cbPrograms.SelectedValue),
                _cbCycles.GetSelectedValue<Cycle>());

            if (form.ShowDialog() == DialogResult.OK)
                SetData(index: _grid.RowCount + 1);
        }

        private void _btnEdit_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
            {
                using var form = new CourseForm(
                    identifiable.Id,
                    Convert.ToInt32(_cbOrganizations.SelectedValue),
                    false,
                    Convert.ToInt32(_cbPrograms.SelectedValue),
                    _cbCycles.GetSelectedValue<Cycle>());

                if (form.ShowDialog() == DialogResult.OK)
                    SetData();
            }
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is CourseModel model)
            {
                using var confirmBox = new ConfirmBox(
                    "Confirm Deletion",
                    $"Are you sure you want to delete {model.Name} (Id: {model.Id})?");

                if (confirmBox.ShowDialog() == DialogResult.OK)
                {
                    using var dc = new Dc();

                    dc.Courses
                        .Where(c => c.CourseId == model.Id)
                        .Delete();

                    SetData();
                }
            }
        }
    }
}
