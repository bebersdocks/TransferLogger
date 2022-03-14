using LinqToDB;

using TransferLogger.BusinessLogic.Utils;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.Definitions;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Utils;

using Lookup = TransferLogger.BusinessLogic.Lookup;

namespace TransferLogger.Ui.Forms.Program
{
    public partial class ProgramForm : Form
    {
        private readonly Dal.DataModels.Program _program;
        private readonly List<Lookup>           _organizations;

        public ProgramForm(int programId = 0)
        {
            InitializeComponent();

            using var dc = new Dc();

            _program = dc.Programs.FirstOrDefault(p => p.ProgramId == programId) ?? new();
            _organizations = dc.Organizations
                .Select(o => new Lookup(o.OrganizationId, o.DisplayString))
                .ToList();

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            if (_program.OrganizationId > 0)
            {
                _tbName.Text       = _program.Name;
                _numericYear.Value = _program.Year;

                _cbCycle.FillLookups(_program.Cycle);
                _cbOrganizations.FillLookups(_organizations, _program.OrganizationId);

                Text = $"{_program.Name} (Id: {_program.ProgramId})";
            }
            else
            {
                _cbCycle.FillLookups(Cycle.Bachelor);
                _cbOrganizations.FillLookups<Lookup>(_organizations);
            }
        }

        private void SetEvents()
        {
            _btnSelectOrganization.Click += _btnSelectOrganization_Click;
            _btnCancel.Click             += _btnCancel_Click;
            _btnOk.Click                 += _btnOk_Click;
        }

        private void _btnSelectOrganization_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Organization", _organizations, _cbOrganizations.SelectedValue);
            
            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbOrganizations.SelectedValue = form.SelectedValue.Value;
            }
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_tbName.Text))
            {
                this.ShowValidationMsg($"{_lName.Text} can't be empty.");
                return;
            }

            if (_cbOrganizations.SelectedValue is null)
            {
                this.ShowValidationMsg($"You have to select {_lOrganization.Text}.");
                return;
            }

            if (_cbCycle.SelectedValue is null)
            {
                this.ShowValidationMsg($"You have to specify {_lCycle.Text}.");
                return;
            }
            
            _program.Name           = _tbName.Text;
            _program.OrganizationId = (int)_cbOrganizations.SelectedValue;
            _program.Cycle          = (Cycle)_cbCycle.SelectedValue;
            _program.Year           = (int)_numericYear.Value;

            using var dc = new Dc();

            if (_program.ProgramId == 0)
                dc.InsertWithIdentity(_program);
            else
                dc.Update(_program);

            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
