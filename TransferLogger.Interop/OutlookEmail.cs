using System.Collections.Generic;
using System.IO;
using System.Linq;

using Microsoft.Office.Interop.Outlook;

using LinqToDB;

using TransferLogger.Interop.Excel;

using DalApplication = TransferLogger.Dal.DataModels.Applications.Application;

namespace TransferLogger.Interop
{
    public class OutlookEmail
    {
        private readonly DalApplication _application;
        private readonly List<string>   _emails;
        private readonly MailItem       _mailItem;

        public OutlookEmail(DalApplication application, List<string> emails, bool saveExcel = false)
        {
            _application = application;
            _emails      = emails;
            _mailItem    = PrepareEmail(saveExcel);
        }

        private MailItem PrepareEmail(bool saveExcel)
        {
            var to       = _emails.First();
            var ccEmails = string.Join(";", _emails.Skip(1));

            var ol = new Application();

            var mailItem = ol.CreateItem(OlItemType.olMailItem) as MailItem;

            mailItem.Subject = $"Transfer evaluation for {_application.Student.DisplayString}";
            mailItem.Body    = string.Empty;
            mailItem.To      = to;
            mailItem.CC      = ccEmails;

            var excelExporter = new ExcelExporter(_application);
            var excelPath     = excelExporter.Export(!saveExcel);

            var excelFileName = _application.ExcelLocation;
            if (string.IsNullOrEmpty(excelFileName))
                excelFileName = $"transfer_application_{_application.ApplicationId}.xlsx";

            mailItem.Attachments.Add(excelPath, OlAttachmentType.olByValue, 1, Path.GetFileName(excelFileName));

            // In case if it was temporary created file - delete it.
            if (!saveExcel)
                File.Delete(excelPath);

            for (var i = 0; i < _application.Attachments.Count(); i++)
            {
                var attachment = _application.Attachments.ElementAt(i);

                if (File.Exists(attachment.FileName))
                {
                    mailItem.Attachments.Add(attachment.FileName, OlAttachmentType.olByValue, i + 2, attachment.FileName);
                }
                else
                {
                    string tempPath = $"{Path.GetTempPath()}{Path.GetFileName(attachment.FileName)}";

                    using var fileStream = new FileStream(tempPath, FileMode.Create);

                    fileStream.Write(attachment.Data);
                    fileStream.Close();

                    mailItem.Attachments.Add(tempPath, OlAttachmentType.olByValue, i + 2, attachment.FileName);

                    File.Delete(tempPath);
                }
            }

            return mailItem;
        }

        public void Display()
        {
            _mailItem.Display(false);

            var inspector = _mailItem.GetInspector;

            inspector.WindowState = OlWindowState.olMinimized;
            inspector.WindowState = OlWindowState.olNormalWindow;
        }
    }
}
