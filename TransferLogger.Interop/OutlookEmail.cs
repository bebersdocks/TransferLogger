using System.IO;
using System.Linq;

using Microsoft.Office.Interop.Outlook;

using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Interop.Excel;

namespace TransferLogger.Interop
{
    public class OutlookEmail
    {
        private readonly int      _appId;
        private readonly MailItem _mailItem;

        public OutlookEmail(int appId)
        {
            _appId    = appId;
            _mailItem = PrepareEmail();
        }

        private MailItem PrepareEmail()
        {
            using var dc = new Dc();

            var application = dc.GetApplication(_appId);

            var instructorIds = application.Evaluations
                .Where(e => e.EvaluationStatus == EvaluationStatus.InProcess)
                .Select(e => e.InstructorId)
                .ToHashSet();

            var emails = dc.Instructors
                .Where(i => instructorIds.Contains(i.InstructorId))
                .Select(i => i.Email)
                .ToList();

            var to       = emails.First();
            var ccEmails = string.Join(";", emails.Skip(1));

            var ol = new Application();

            var mailItem = ol.CreateItem(OlItemType.olMailItem) as MailItem;

            mailItem.Subject = $"Transfer evaluation for {application.Student.DisplayString}";
            mailItem.Body    = string.Empty;
            mailItem.To      = to;
            mailItem.CC      = ccEmails;

            var excelExporter = new ExcelExporter(application);
            var excelLocation = excelExporter.Export();

            mailItem.Attachments.Add(excelLocation, OlAttachmentType.olByValue, 1, Path.GetFileName(excelLocation));

            // In case if it was temporary created file - delete it.
            if (string.IsNullOrEmpty(application.ExcelLocation))
                File.Delete(excelLocation);

            for (var i = 0; i < application.Attachments.Count(); i++)
            {
                var attachment = application.Attachments.ElementAt(i);

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
        }
    }
}
