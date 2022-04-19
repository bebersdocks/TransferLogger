﻿using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Office.Interop.Excel;

using LinqToDB;

using TransferLogger.BusinessLogic.Settings;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

using DalApplication = TransferLogger.Dal.DataModels.Applications.Application;
using Range          = Microsoft.Office.Interop.Excel.Range;

namespace TransferLogger.Interop.Excel
{
    public class ExcelExporter
    {
        private readonly DalApplication _application;

        public ExcelExporter(DalApplication application)
        {
            _application = application;
        }

        public ExcelExporter(int appId)
        {
            using var dc = new Dc();

            _application = dc.Applications
                .Where(a => a.ApplicationId == appId)
                .LoadWith(a => a.Student)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.Course)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.Instructor)
                .LoadWith(a => a.Evaluations)
                .ThenLoad(e => e.Course)
                .First();
        }

        private static readonly HashSet<string> _appVars = new()
        {
            "%AppId%",
            "%Student%",
            "%Program%"
        };

        private void ReplaceAppVar(Range cell, string variable)
        {
            cell.Value = variable switch
            {
                "%AppId%"   => _application.ApplicationId,
                "%Student%" => _application.Student.DisplayString,
                _           => string.Empty
            };
        }

        private static readonly HashSet<string> _evaluationVars = new()
        {
            "%EvaluationId%",
            "%CourseCode%",
            "%Course%",
            "%Instructor%",
            "%SuggestedCourse%"
        };

        private void ReplaceEvaluationVar(Range cell, string variable, Evaluation evaluation)
        {
            cell.Value = variable switch
            {
                "%EvaluationId%"    => evaluation.EvaluationId,
                "%CourseCode%"      => evaluation.Course.CourseCode,
                "%Course%"          => evaluation.Course.DisplayString,
                "%Instructor%"      => evaluation.Instructor.DisplayString,
                "%SuggestedCourse%" => evaluation.SuggestedCourse?.CourseCode ?? string.Empty,
                _                   => string.Empty
            };
        }

        public void Export(string fileName)
        {
            Application excelApp = null;
            Workbook    workbook = null;

            try
            {
                excelApp = new Application();
                workbook = excelApp.Workbooks.Open(AppSettings.Instance.ExcelTemplatePath);

                var sheet = workbook.Sheets[1] as Worksheet;

                var tableRowIdx = 0;
                var tableColIndexes = new Dictionary<int, string>();

                // Goes through cells to replace simple variables and to determine where evaluation table starts.
                for (var rowIdx = 1; rowIdx <= sheet.UsedRange.Rows.Count; rowIdx++)
                {
                    var range = sheet.UsedRange.Rows[rowIdx];

                    for (var colIdx = 1; colIdx < range.Columns.Count; colIdx++)
                    {
                        var cell = range.Columns[colIdx];

                        if (cell.Value == null)
                            continue;

                        string variable = cell.Value.ToString();

                        if (_appVars.Contains(variable))
                        {
                            ReplaceAppVar(cell, variable);
                        }
                        else if (_evaluationVars.Contains(variable))
                        {
                            tableRowIdx = rowIdx;
                            tableColIndexes.TryAdd(colIdx, variable);
                        }
                    }
                }

                // Inserts application evaluations into found excel cells.  
                if (tableRowIdx > 0 && tableColIndexes.Any())
                {
                    var tableRow = sheet.UsedRange.Rows[tableRowIdx] as Range;

                    var currentRowIdx = tableRowIdx;

                    foreach (var evaluation in _application.Evaluations)
                    {
                        sheet.Rows[tableRowIdx].Copy(sheet.Rows[currentRowIdx]);

                        for (var colIdx = 1; colIdx < tableRow.Columns.Count; colIdx++)
                        {
                            if (tableColIndexes.TryGetValue(colIdx, out var variable))
                            {
                                var cell = sheet.Cells[currentRowIdx, colIdx];

                                ReplaceEvaluationVar(cell, variable, evaluation);
                            }
                        }

                        currentRowIdx++;
                    }
                }

                workbook.SaveCopyAs(fileName);
            }
            catch (Exception) 
            {
                throw; // Propagate exception further to the global handler.
            }
            finally // Close application.
            {
                workbook?.Close(false);
                excelApp?.Quit();
            }
        }

        public string Export()
        {
            var exportPath = _application.ExcelLocation;
            if (string.IsNullOrEmpty(exportPath))
                exportPath = $"{AppSettings.Instance.ExcelExportsDir}\\transfer_application_{_application.ApplicationId}.xlsx";

            Export(exportPath);

            return exportPath;
        }
    }
}
