using System;
using System.Drawing;
using System.Windows.Forms;

using LinqToDB;

using Serilog;

using TransferLogger.Dal;
using TransferLogger.Ui.Forms.Utils;

using static System.Windows.Forms.Control;

namespace TransferLogger.Ui.Utils
{
    public static class FormUtils
    {
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

                ExceptionForm.Show(ex);
                
                return false;
            }
        }

        public static bool TryInsertOrReplace<T>(T obj, int id = 0) where T : notnull
        {
            return TryInsertOrReplace(obj, ref id);
        }

        public static void SetReadOnly(Control control, bool readOnly = true)
        {
            var backColor = readOnly ? SystemColors.InactiveBorder : Color.GhostWhite;

            control.TabStop = !readOnly;

            if (control is TextBox textBox)
            {
                textBox.BackColor = backColor;
                textBox.ReadOnly  = readOnly;
            }
            else if (control is Button button)
            {
                button.Enabled = !readOnly;
            }
            else if (control is ComboBox comboBox)
            {
                comboBox.Enabled = !readOnly;
            }
            else if (control is NumericUpDown numericUpDown)
            {
                numericUpDown.BackColor = backColor;
                numericUpDown.Enabled   = !readOnly;
            }
        }

        public static void SetReadOnly(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                SetReadOnly(control);
            }
        }
    }
}
