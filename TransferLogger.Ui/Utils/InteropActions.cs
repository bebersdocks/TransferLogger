using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Interop;
using TransferLogger.Interop.Excel;
using TransferLogger.Ui.Forms.Dialogs;
using TransferLogger.Ui.Forms.Utils;

namespace TransferLogger.Ui.Utils
{
    public static class InteropActions
    {
        public static async Task SendEmail(Form caller, int appId, bool silent = false)
        {
            using var dc = new Dc();

            var application = dc.GetApplication(appId);

            var instructorIds = application.Evaluations
                .Where(e => e.EvaluationStatus == EvaluationStatus.InProcess)
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
                    MessageDialog.Show("There are no instructors to send email to.", "Aborted");
                }

                return;
            }

            var task = Task.Run(() => new OutlookEmail(application, emails));

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
    }
}
