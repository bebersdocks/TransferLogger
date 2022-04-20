using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.Dal.DataModels.Applications;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class AttachmentsControl : UserControl, IWizardControl
    {
        private readonly ApplicationBuild _appBuild;

        public AttachmentsControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetData();
            SetEvents();
        }

        public void Activate()
        {
            BringToFront();
        }

        private void SetData()
        {
            _tbExcelLocation.Text = _appBuild.ExcelLocation;
            _grid.DataSource      = _appBuild.Attachments.ToList();
            _btnView.Enabled      = _appBuild.Attachments.Any();
        }

        private void SetEvents()
        {
            _btnBrowse.Click  += _btnBrowse_Click;
            _btnAdd.Click     += _btnAdd_Click;
            _btnView.Click    += _btnView_Click;
            _grid.DoubleClick += _btnView_Click;
            _btnDelete.Click  += _btnDelete_Click;
        }

        private void _btnBrowse_Click(object? sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog();

            fileDialog.CheckFileExists  = false;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = fileDialog.FileName;

                if (!fileName.EndsWith(".xlsx"))
                    fileName += ".xlsx";

                _tbExcelLocation.Text = _appBuild.ExcelLocation = fileName;
            }
        }

        private async void _btnAdd_Click(object? sender, EventArgs e)
        {
            using var fileDialog = new OpenFileDialog();

            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                _btnAdd.Enabled = _btnView.Enabled = _btnDelete.Enabled = false;

                foreach (var fileName in fileDialog.FileNames)
                {
                    var newAttachment = new ApplicationAttachment();

                    newAttachment.FileName = fileDialog.FileName;
                    newAttachment.Data     = await File.ReadAllBytesAsync(fileName);

                    _appBuild.Attachments.Add(newAttachment);
                }

                SetData();

                _grid.SelectRow(_grid.RowCount - 1);

                _btnAdd.Enabled = _btnView.Enabled = _btnDelete.Enabled = true;
            }
        }

        private void _btnView_Click(object? sender, EventArgs e)
        {
            _btnView.Enabled = false;

            if (_grid.CurrentRow?.DataBoundItem is ApplicationAttachment attachment)
            {
                var startInfo = new ProcessStartInfo(attachment.FileName)
                {
                    UseShellExecute = true
                };

                Process.Start(startInfo);
            }

            _btnView.Enabled = true;
        }

        private void _btnDelete_Click(object? sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is ApplicationAttachment attachment)
            {
                var index = _grid.CurrentRow.Index;

                _appBuild.Attachments.Remove(attachment);

                SetData();

                _grid.SelectRow(index);
            }
        }

        public bool Complete()
        {
            return true;
        }
    }
}
