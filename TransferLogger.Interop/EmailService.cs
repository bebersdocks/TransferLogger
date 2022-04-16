using System.IO;
using System.Linq;

using Microsoft.Office.Interop.Outlook;

using LinqToDB;

using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

namespace TransferLogger.Interop
{
    public static class EmailService
    {
        public static void PrepareEmail(int appId)
        {
            using var dc = new Dc();

            var application = dc.Applications
                .Where(a => a.ApplicationId == appId)
                .LoadWith(a => a.Student)
                .LoadWith(a => a.Evaluations)
                .LoadWith(a => a.Attachments)
                .First();

            var instructorIds = application.Evaluations
                .Where(e => e.EvaluationStatus == EvaluationStatus.InProcess)
                .Select(e => e.InstructorId)
                .ToHashSet();

            if (instructorIds.Any())
            {
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

                for (var i = 0; i < application.Attachments.Count(); i++)
                {
                    var attachment = application.Attachments.ElementAt(i);

                    if (File.Exists(attachment.FileName))
                    {
                        mailItem.Attachments.Add(attachment.FileName, OlAttachmentType.olByValue, i + 1, attachment.FileName);
                    }
                    else
                    {
                        string tempPath = $"{Path.GetTempPath()}{Path.GetFileName(attachment.FileName)}";

                        using var fileStream = new FileStream(tempPath, FileMode.Create);

                        fileStream.Write(attachment.Data);
                        fileStream.Close();

                        mailItem.Attachments.Add(tempPath, OlAttachmentType.olByValue, i + 1, attachment.FileName);

                        File.Delete(tempPath);
                    }
                }

                mailItem.Display(false);
            }
        }
    }
}
