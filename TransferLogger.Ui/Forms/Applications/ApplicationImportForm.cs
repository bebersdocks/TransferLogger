using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using LinqToDB;

using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;

using DalApplication = TransferLogger.Dal.DataModels.Applications.Application;

namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ApplicationImportForm : Form
    {
        private readonly DalApplication   _application;
        private readonly List<Evaluation> _evaluations;
        private readonly List<Evaluation> _imports;

        public ApplicationImportForm(int appId, List<Evaluation> evaluations, List<Evaluation> imports)
        {
            InitializeComponent();

            using var dc = new Dc();

            _application = dc.GetApplication(appId);
            _evaluations = evaluations;
            _imports     = imports;

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            _tbApplication.Text   = _application.ApplicationId.ToString();
            _tbStudent.Text       = _application.Student.DisplayString;
            _tbOrganization.Text  = _application.SourceOrganization.DisplayString;
            _tbTargetProgram.Text = _application.TargetProgram.DisplayString;

            _gridEvaluations.DataSource = _evaluations
                .Select(e => new EvaluationViewModel(e, _application))
                .ToList();

            _gridImportResults.DataSource = _imports
                .Select(e => new EvaluationViewModel(e, _application))
                .ToList();
        }

        private void SetEvents()
        {
            _btnCancel.Click += _btnCancel_Click;
            _btnAccept.Click += _btnAccept_Click;
        }

        private void _btnCancel_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void _btnAccept_Click(object? sender, EventArgs e)
        {
            using var dc = new Dc();
            using var tr = dc.BeginTransaction();

            foreach (var evaluation in _imports)
                dc.Update(evaluation);

            tr.Commit();

            DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
