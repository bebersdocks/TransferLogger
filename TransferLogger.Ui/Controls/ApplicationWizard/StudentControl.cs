﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Ui.Forms;
using TransferLogger.Ui.Forms.Dialogs;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class StudentControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild        _appBuild;
        private readonly Students.StudentControl _studentControl;

        private readonly List<Lookup> _students = LookupServices.GetStudents();

        public StudentControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            _studentControl = new Students.StudentControl(appBuild.Student);

            _pnlNewStudent.Controls.Add(_studentControl);

            _rbExistingStudent.Checked = true;

            SetData();
            SetControls();
            SetEvents();
        }

        public void Activate()
        {
            BringToFront();
        }

        private void SetData()
        {
            _cbStudents.FillLookups(_students, _appBuild.Student.StudentId);
        }

        private void SetControls()
        {
            var useExisting = _rbExistingStudent.Checked;

            _cbStudents.Enabled       = useExisting;
            _btnSelectStudent.Enabled = useExisting;
            _rbNewStudent.Checked     = !useExisting;
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

        public bool Complete()
        {
            if (_rbExistingStudent.Checked)
            {
                _appBuild.Student.StudentId = Convert.ToInt32(_cbStudents.SelectedValue);

                if (_appBuild.Student.StudentId <= 0)
                {
                    MessageDialog.Show("You have to select student.", "Wizard Validation");

                    return false;
                }

                return true;
            }
            else if (_studentControl.ValidateData() && _studentControl.Save(out var studentId))
            {
                _appBuild.Student.StudentId = studentId;

                return true;
            }

            return false;
        }
    }
}
