using System;
using System.IO;

using Microsoft.Office.Interop.Excel;

namespace TransferLogger.Interop.Excel
{
    public class ExcelViewer
    {
        private readonly string _fileName;

        public ExcelViewer(string fileName)
        {
            if (!File.Exists(fileName))
                throw new FileNotFoundException(fileName);

            if (string.IsNullOrEmpty(fileName) || !fileName.EndsWith(".xlsx"))
                throw new ArgumentOutOfRangeException(fileName);

            _fileName = fileName;
        }

        public void Open()
        {
            Application excelApp = null;
            Workbook    workbook = null;

            try
            {
                excelApp = new Application();
                excelApp.Visible = true;

                workbook = excelApp.Workbooks.Open(_fileName);

                // Brings window to front.
                excelApp.WindowState = XlWindowState.xlMinimized;
                excelApp.WindowState = XlWindowState.xlNormal;
            }
            catch (Exception)
            {
                workbook?.Close(false);
                excelApp?.Quit();

                throw;
            }
        }
    }
}
