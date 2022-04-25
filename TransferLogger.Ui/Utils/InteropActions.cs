using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransferLogger.Interop;
using TransferLogger.Interop.Excel;
using TransferLogger.Ui.Forms.Utils;

namespace TransferLogger.Ui.Utils
{
    public static class InteropActions
    {
        public static async Task SendEmail(Form caller, int appId)
        {
            var task = Task.Run(() => new OutlookEmail(appId));

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
