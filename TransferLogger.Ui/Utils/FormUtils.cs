using System;
using System.Windows.Forms;

using LinqToDB;

using Serilog;

using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Dal;
using TransferLogger.Ui.Controls;
using TransferLogger.Ui.Forms.Dialogs;

namespace TransferLogger.Ui.Utils
{
    public static class FormUtils
    {
        public static void ShowForm<T>(Func<T> getForm) where T : Form
        {
            using var form = getForm();

            form.ShowDialog();
        }

        public static void InsertOrReplace(TlDataGrid grid, Func<int, Form> getForm, Action setData, bool isNew = false)
        {
            var itemId = 0;

            if (grid.CurrentRow?.DataBoundItem is IIdentifiable viewModel)
            {
                itemId = viewModel.Id;
            }

            if (!isNew && itemId == 0)
            {
                return;
            }

            using var form = getForm(isNew ? 0 : itemId);

            if (form.ShowDialog() == DialogResult.OK)
            {
                setData();

                if (!isNew)
                {
                    grid.SelectRow<IIdentifiable>(vm => vm.Id == itemId);
                }
                else
                {
                    grid.SelectRow(grid.Rows.Count - 1);
                }
            }
        }

        public static bool TryInsertOrReplace<T>(T obj, ref int id) where T : notnull
        {
            try
            {
                using var dc = new Dc();

                if (id == 0)
                    id = dc.InsertWithInt32Identity(obj);
                else
                    dc.Update(obj);

                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "failed");

                ErrorDialog.Show(ex.Message, "Database Error");
                
                return false;
            }
        }

        public static bool TryInsertOrReplace<T>(T obj, int id = 0) where T : notnull
        {
            return TryInsertOrReplace(obj, ref id);
        }
    }
}
