using TransferLogger.BusinessLogic;

namespace TransferLogger.Ui.Forms
{
    public partial class LookupSelectionForm : Form
    {
        private readonly List<Lookup> _lookups;

        private int? _selectedValue;
        public int? SelectedValue => _selectedValue;

        public LookupSelectionForm(string title, List<Lookup> lookups, object? selectedObj)
        {
            InitializeComponent();

            Text = title;

            _lookups       = lookups;
            _selectedValue = selectedObj != null ? Convert.ToInt32(selectedObj) : null;

            SetData();
            SetEvents();
        }

        private void SetEvents()
        {
            _tbSearchLookup.TextChanged += _tbSearchLookup_TextChanged;

            _grid.DoubleClick += _btnOk_Click;

            _btnClear.Click  += _btnClear_Click;
            _btnCancel.Click += _btnCancel_Click;
            _btnOk.Click     += _btnOk_Click;
        }

        private void _tbSearchLookup_TextChanged(object? sender, EventArgs e)
        {
            SetData(_tbSearchLookup.Text);
        }

        private void SetData(string displayName = "")
        {
            if (!string.IsNullOrEmpty(displayName))
                _grid.DataSource = _lookups
                    .Where(l => l.DisplayName.Contains(displayName, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            else
                _grid.DataSource = _lookups;

            if (_selectedValue.HasValue)
                _grid.SelectRow<Lookup>(l => l.Value == _selectedValue.Value);
        }

        private void _btnClear_Click(object? sender, EventArgs e)
        {
            _selectedValue = -1;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count == 1 && _grid.SelectedRows[0].DataBoundItem is Lookup lookup)
            {
                _selectedValue = lookup.Value;
            }

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
