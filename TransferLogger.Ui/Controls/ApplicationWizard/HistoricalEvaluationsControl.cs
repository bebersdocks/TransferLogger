﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Models;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Ui.Forms.Applications;
using TransferLogger.Ui.Forms.Courses;

namespace TransferLogger.Ui.Controls.ApplicationWizard
{
    public partial class HistoricalEvaluationsControl : UserControl, IWizardControl
    {
        private int _currentCourseId = 0;

        private readonly ApplicationBuild _appBuild;

        public HistoricalEvaluationsControl(ApplicationBuild appBuild)
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _appBuild = appBuild;

            SetEvents();
        }
        public void Activate()
        {
            SetData();

            BringToFront();

            _gridCourses.Focus();
        }

        private void SetData()
        {
            using var dc = new Dc();

            var courseIds = dc.Courses
                .Where(c => _appBuild.Evaluations.ContainsKey(c.CourseId))
                .Where(c => c.Evaluations.Any(e => e.EvaluationStatus != EvaluationStatus.InProcess))
                .Select(c => c.CourseId)
                .ToHashSet();

            if (_currentCourseId <= 0 && !_appBuild.Evaluations.ContainsKey(_currentCourseId))
                _currentCourseId = courseIds.FirstOrDefault();

            if (_currentCourseId > 0)
            {
                _gridCourses.SelectionChanged -= _gridCourses_SelectionChanged;

                _gridCourses.DataSource = _appBuild.Evaluations.Values
                    .Where(e => courseIds.Contains(e.CourseId))
                    .OrderBy(e => e.CourseId)
                    .Select(e => new BuildEvaluationModel(dc, e))
                    .ToList();

                _gridCourses.SelectRow<ApplicationEvaluation>(e => e.CourseId == _currentCourseId);

                _gridCourses.SelectionChanged += _gridCourses_SelectionChanged;

                SetHistoricalEvaluations();
            }
        }

        private void SetHistoricalEvaluations()
        {
            var evaluation = _appBuild.Evaluations[_currentCourseId];

            _gridHistoricalEvaluations.SelectionChanged -= _gridHistoricalEvaluations_SelectionChanged;

            _gridHistoricalEvaluations.DataSource = EvaluationModel.GetHistoricalEvaluations(_currentCourseId);

            if (evaluation.HistoricalEvaluationId > 0)
                _gridHistoricalEvaluations.SelectRow<IIdentifiable>(i => i.Id == evaluation.HistoricalEvaluationId);

            _gridHistoricalEvaluations.SelectionChanged += _gridHistoricalEvaluations_SelectionChanged;

            SetHistoricalControls();
        }

        private void SetHistoricalControls()
        {
            _pnlEvaluationDetails.Enabled = _appBuild.Evaluations[_currentCourseId].HistoricalEvaluationId > 0;

            if (_gridHistoricalEvaluations.CurrentRow?.DataBoundItem is EvaluationModel model)
            {
                _tbMatchedCourse.Text = model.MatchedCourse;
                _tbStudent.Text       = model.Student;
                _tbEvaluator.Text     = model.Instructor;
                _tbComment.Text       = model.Comment;

                _btnViewMatchedCourse.Enabled = model.MatchedCourseId > 0;
            }
            else
            {
                _tbMatchedCourse.Text = _tbStudent.Text = _tbEvaluator.Text  = _tbComment.Text = "";
            }
        }

        private void SetEvents()
        {
            _gridCourses.CellClick       += (s, e) => SetCurrentRowHistoricalUsage(e.ColumnIndex == 1);
            _gridCourses.CellDoubleClick += (s, e) => SetCurrentRowHistoricalUsage(e.ColumnIndex == 1);

            _btnViewMatchedCourse.Click += _btnViewMatchedCourse_Click;
            _btnViewApplication.Click   += _btnViewApplication_Click;
        }

        // Refreshes the grid to display current value of UseHistorical checkbox.
        private void UpdateRowsHistoricalUsage()
        {
            if (_gridCourses.DataSource is List<BuildEvaluationModel> evaluations)
            {
                foreach (var evaluation in evaluations)
                {
                    evaluation.UseHistorical = _appBuild.Evaluations[evaluation.CourseId].HistoricalEvaluationId > 0;
                }

                _gridCourses.Refresh();
            }
        }

        private void SetCurrentRowHistoricalUsage(bool toggleHistoricalUsage = true)
        {
            if (_gridCourses.CurrentRow?.DataBoundItem is BuildEvaluationModel model)
            {
                if (toggleHistoricalUsage)
                {
                    model.UseHistorical = !model.UseHistorical;
                }

                var evaluation = _appBuild.Evaluations[model.CourseId];

                if (model.UseHistorical && _gridHistoricalEvaluations.CurrentRow?.DataBoundItem is IIdentifiable identifiable)
                {
                    evaluation.HistoricalEvaluationId = identifiable.Id;
                }
                else
                {
                    evaluation.HistoricalEvaluationId = 0;
                }

                UpdateRowsHistoricalUsage();

                SetHistoricalControls();
            }
        }

        private void _gridCourses_SelectionChanged(object? sender, EventArgs e)
        {
            if (_gridCourses.CurrentRow?.DataBoundItem is BuildEvaluationModel model)
            {
                _currentCourseId = model.CourseId;

                SetHistoricalEvaluations();
            }
        }

        private void _gridHistoricalEvaluations_SelectionChanged(object? sender, EventArgs e)
        {
            SetCurrentRowHistoricalUsage(false);
        }

        private void _btnViewMatchedCourse_Click(object? sender, EventArgs e)
        {
            if (_gridHistoricalEvaluations.CurrentRow?.DataBoundItem is EvaluationModel model && model.MatchedCourseId.HasValue)
            {
                using var form = new CourseForm(model.MatchedCourseId.Value);

                form.ShowDialog();
            }
        }

        private void _btnViewApplication_Click(object? sender, EventArgs e)
        {
            if (_gridHistoricalEvaluations.CurrentRow?.DataBoundItem is EvaluationModel model)
            {
                using var form = new ApplicationForm(model.ApplicationId, true);

                form.ShowDialog();
            }
        }

        public bool Complete()
        {
            return true;
        }
    }
}
