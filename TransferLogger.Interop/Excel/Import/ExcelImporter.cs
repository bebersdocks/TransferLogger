using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Office.Interop.Excel;

using TransferLogger.Dal.DataModels;

using Range = Microsoft.Office.Interop.Excel.Range;

namespace TransferLogger.Interop.Excel.Import
{
    public enum ImportColumn
    {
        EvaluationId,
        Transfer,
        Comment
    }

    public static class ExcelImporter
    {
        private static bool TryParseColumn(string column, out ImportColumn? importColumn)
        {
            importColumn = null;

            column = column.Replace(" ", string.Empty);

            if (column.Contains("EvaluationId", StringComparison.OrdinalIgnoreCase))
                importColumn = ImportColumn.EvaluationId;
            else if (column.Contains("Transfer", StringComparison.OrdinalIgnoreCase))
                importColumn = ImportColumn.Transfer;
            else if (column.Contains("Comment", StringComparison.OrdinalIgnoreCase))
                importColumn = ImportColumn.Comment;

            return importColumn.HasValue;
        }

        public static List<EvaluationImport> ImportEvaluations(string fileName)
        {
            Application excelApp = null;
            Workbook    workbook = null;

            var imports = new List<EvaluationImport>();

            try
            {
                excelApp = new Application();
                workbook = excelApp.Workbooks.Open(fileName);

                var sheet = workbook.Sheets[1] as Worksheet;

                var tableRowIdx     = 0;
                var tableColIndexes = new Dictionary<ImportColumn, int>();

                for (var rowIdx = 1; rowIdx <= sheet.UsedRange.Rows.Count; rowIdx++)
                {
                    var range = sheet.UsedRange.Rows[rowIdx];

                    for (var colIdx = 1; colIdx <= range.Columns.Count; colIdx++)
                    {
                        var cell = range.Columns[colIdx];

                        if (cell.Value == null)
                            continue;

                        string column = cell.Value.ToString();

                        if (TryParseColumn(column, out var importColumn))
                        {
                            tableRowIdx                         = rowIdx;
                            tableColIndexes[importColumn.Value] = colIdx;
                        }
                    }
                }

                if (tableRowIdx > 0 && tableColIndexes.Any())
                {
                    var tableRow = sheet.UsedRange.Rows[tableRowIdx] as Range;

                    for (var rowIdx = tableRowIdx + 1; rowIdx <= sheet.UsedRange.Rows.Count; rowIdx++)
                    {
                        var import = new EvaluationImport();

                        foreach (var (importColumn, colIdx) in tableColIndexes)
                        {
                            var cell = sheet.Cells[rowIdx, colIdx];

                            if (cell.Value == null)
                                continue;

                            if (importColumn == ImportColumn.EvaluationId)
                            {
                                import.EvaluationId = Convert.ToInt32(cell.Value);
                            }
                            else if (importColumn == ImportColumn.Transfer)
                            {
                                string value = cell.Value.ToString()
                                    .Replace(" ", string.Empty);

                                import.EvaluationStatus = EvaluationStatus.InProcess;

                                if (value.Contains("Yes", StringComparison.OrdinalIgnoreCase))
                                    import.EvaluationStatus = EvaluationStatus.Matched;
                                else if (value.Equals("No", StringComparison.OrdinalIgnoreCase))
                                    import.EvaluationStatus = EvaluationStatus.NotMatched;
                                else
                                    import.AlternativeCourse = value.Trim();
                            }
                            else if (importColumn == ImportColumn.Comment)
                            {
                                import.Comment = cell.Value.ToString();
                            }
                        }

                        imports.Add(import);
                    }
                }

                return imports;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                workbook?.Close(false);
                excelApp?.Quit();
            }
        }
    }
}
