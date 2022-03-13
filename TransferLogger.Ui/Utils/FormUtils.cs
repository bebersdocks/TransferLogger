using TransferLogger.BusinessLogic.Intefaces;
using TransferLogger.Ui.Controls;

namespace TransferLogger.Ui.Utils
{
    public static class FormUtils
    {
        public static void ShowForm<T>(Func<T> getForm) where T : Form
        {
            using var form = getForm();

            form.ShowDialog();
        }

        public static void ShowValidationMsg(this Form form, string msg)
        {
            MessageBox.Show(form, msg, "Validation error");
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
    }
}
