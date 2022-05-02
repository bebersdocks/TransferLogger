using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;

namespace TransferLogger.Ui.Forms
{
    public partial class LookupSelectionForm : Form
    {
        private readonly IList<Lookup> _lookups;

        private int? _selectedValue;
        public int? SelectedValue => _selectedValue;

        public LookupSelectionForm(string title, IList<Lookup> lookups, object? selectedObj)
        {
            InitializeComponent();

            Text = title;

            _lookups       = lookups;
            _selectedValue = selectedObj != null ? Convert.ToInt32(selectedObj) : null;

            SetData();
            SetEvents();
        }

        private void SetData(string displayName = "")
        {
            if (!string.IsNullOrEmpty(displayName))
                _grid.DataSource = _lookups
                    .Where(l => l.DisplayName.Contains(displayName))
                    .ToList();
            else
                _grid.DataSource = _lookups;

            if (_selectedValue.HasValue)
                _grid.SelectRow<Lookup>(l => l.Value == _selectedValue.Value);
        }

        private void SetEvents()
        {
            _grid.DoubleClick += (s, e) => Ok();
            _btnOk.Click      += (s, e) => Ok();

            _grid.KeyDown += _grid_KeyDown;

            _tbSearchLookup.TextChanged += _tbSearchLookup_TextChanged;

            _btnClear.Click  += _btnClear_Click;
            _btnCancel.Click += _btnCancel_Click;
        }

        private void _grid_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Ok();
        }

        private void _tbSearchLookup_TextChanged(object? sender, EventArgs e)
        {
            SetData(_tbSearchLookup.Text);
        }

        private void Ok()
        {
            if (_grid.SelectedRows.Count == 1 && _grid.SelectedRows[0].DataBoundItem is Lookup lookup)
                _selectedValue = lookup.Value;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void _btnClear_Click(object? sender, EventArgs e)
        {
            _selectedValue = -1;

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
