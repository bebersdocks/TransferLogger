using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.BusinessLogic.Utils;
using TransferLogger.BusinessLogic.ViewModels;
using TransferLogger.Dal;
using TransferLogger.Dal.DataModels;
using TransferLogger.Dal.DataModels.Applications;
using TransferLogger.Interop.Excel.Import;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Courses;
using TransferLogger.Ui.Utils;

using DalApplication = TransferLogger.Dal.DataModels.Applications.Application;
namespace TransferLogger.Ui.Forms.Applications
{
    public partial class ApplicationImport : Form
    {
        private readonly DalApplication         _application;
        private readonly List<EvaluationImport> _imports;

        public ApplicationImport(int appId, List<EvaluationImport> imports)
        {
            InitializeComponent();

            using var dc = new Dc();

            _application = dc.GetApplication(appId);
            _imports     = imports;

            SetData();
            SetEvents();
        }

        private void SetData()
        {
            _tbApplication.Text   = $"{_application.ApplicationId}";
            _tbStudent.Text       = _application.Student.DisplayString;
            _tbOrganization.Text  = _application.SourceOrganization.DisplayString;
            _tbTargetProgram.Text = _application.TargetProgram.DisplayString;
        }

        private void SetEvents()
        {

        }
    }
}
