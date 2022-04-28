using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.Dal;

using DalApplication = TransferLogger.Dal.DataModels.Applications.Application;

namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ChangeExcelLocationForm : Form
    {
        private readonly int _appId;

        public ChangeExcelLocationForm(int appId)
        {
            InitializeComponent();

            _appId = appId;

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            using var dc = new Dc();

            _tbExcelLocation.Text = dc.Applications.First(a => a.ApplicationId == _appId)
                .ExcelLocation;
        }

        private void SetEvents()
        {
            _btnBrowse.Click += _btnBrowse_Click;
            _btnClear.Click  += _btnClear_Click;
            _btnOk.Click     += _btnOk_Click;
            _btnCancel.Click += _btnCancel_Click;
        }

        private void _btnBrowse_Click(object? sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog();

            fileDialog.CheckFileExists  = false;
            fileDialog.FileName         = Path.GetFileName(_tbExcelLocation.Text);
            fileDialog.RestoreDirectory = true;
            fileDialog.Title            = "Choose excel location";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = fileDialog.FileName;

                if (!fileName.EndsWith(".xls") && !fileName.EndsWith(".xlsx"))
                    fileName += ".xlsx";

                _tbExcelLocation.Text = fileName;
            }
        }

        private void _btnClear_Click(object? sender, EventArgs e)
        {
            _tbExcelLocation.Text = string.Empty;
        }

        private void _btnOk_Click(object? sender, EventArgs e)
        {
            var newExcelLocation = _tbExcelLocation.Text?.Trim() ?? string.Empty;

            using var dc = new Dc();

            dc.Applications.Update(a => a.ApplicationId == _appId, a => new DalApplication { ExcelLocation = newExcelLocation });

            DialogResult = DialogResult.OK;

            Close();
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
