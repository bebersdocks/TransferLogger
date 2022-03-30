using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Ui.Controls.Students;
using TransferLogger.Ui.Forms;

namespace TransferLogger.Ui.Controls.Applications.Builder
{
    public partial class SelectStudentControl : UserControl
    {
        private bool useExisting = true;

        private readonly StudentControl _studentControl;
        private readonly List<Lookup> _students = LookupServices.GetStudents();

        public SelectStudentControl()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _studentControl = new StudentControl();

            _pnlNewStudent.Controls.Add(_studentControl);

            SetData();
            SetControls();
            SetEvents();
        }

        public void SetData()
        {
            _cbStudents.FillLookups(_students, _cbStudents.SelectedValue);
        }

        private void SetControls()
        {
            useExisting = _rbExistingStudent.Checked;

            _cbStudents.Enabled       = useExisting;
            _btnSelectStudent.Enabled = useExisting;
            _pnlNewStudent.Enabled    = !useExisting;
        }

        private void SetEvents()
        {
            _rbExistingStudent.CheckedChanged += (s, e) => SetControls();
            _rbNewStudent.CheckedChanged      += (s, e) => SetControls();

            _btnSelectStudent.Click += _btnSelectStudent_Click;
        }

        private void _btnSelectStudent_Click(object? sender, EventArgs e)
        {
            using var form = new LookupSelectionForm("Select Student", _students, _cbStudents.SelectedValue);

            if (form.ShowDialog() == DialogResult.OK && form.SelectedValue.HasValue)
            {
                _cbStudents.SelectedValue = form.SelectedValue.Value;
            }
        }
    }
}
