using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferLogger.Dal;
using TransferLogger.Interop;
using TransferLogger.Interop.Excel;
using TransferLogger.Interop.Excel.Import;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Forms.Utils;

namespace TransferLogger.Ui.Utils
{
    public static class InteropActions
    {
        public static async Task SendEmail(Form caller, int appId, bool saveExcel = false, bool silent = false)
        {
            using var dc = new Dc();

            var application = dc.GetApplication(appId);

            // Do not send notifications to historical evaluators.
            var instructorIds = application.Evaluations
                .Where(e => e.LinkedEvaluation == null)
                .Select(e => e.InstructorId)
                .ToHashSet();

            var emails = dc.Instructors
                .Where(i => instructorIds.Contains(i.InstructorId) && !string.IsNullOrEmpty(i.Email))
                .Select(i => i.Email)
                .ToList();

            if (!emails.Any())
            {
                if (!silent)
                {
                    MessageDialog.Show("There are no instructors to notify to.", "Aborted");
                }

                return;
            }

            var task = Task.Run(() => new OutlookEmail(application, emails, saveExcel));

            using var form = new LoadingForm("Email", "Preparing email...");

            caller.BeginInvoke((Action)(() => form.ShowDialog()));

            var outlookEmail = await task;

            outlookEmail.Display();
        }

        public static async Task ExportExcel(Form caller, int appId)
        {
            var task = Task.Run(() => new ExcelExporter(appId).Export());

            using var form = new LoadingForm("Excel Export", "Exporting...");

            caller.BeginInvoke((Action)(() => form.ShowDialog()));

            var excelPath = await task;

            new ExcelViewer(excelPath).Open();
        }

        public static async Task<List<EvaluationImport>?> ImportEvaluations(Form caller)
        {
            using var fileDialog = new OpenFileDialog();

            fileDialog.CheckFileExists  = true;
            fileDialog.Filter           = "Excel Files (*.xlsx)|*.xlsx";
            fileDialog.RestoreDirectory = true;
            fileDialog.Title            = "Select application excel file";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var task = Task.Run(() => ExcelImporter.ImportEvaluations(fileDialog.FileName));

                using var form = new LoadingForm("Excel Import", "Importing...");

                caller.BeginInvoke((Action)(() => form.ShowDialog()));

                return await task;
            }

            return null;
        }
    }
}
