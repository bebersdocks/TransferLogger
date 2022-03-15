using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransferLogger.Ui.Controls
{
    public class TlDataGrid : DataGridView
    {
        private static DataGridViewCellStyle GetColumnsHeaderDefaultStyle()
        {
            return new DataGridViewCellStyle
            {
                Alignment          = DataGridViewContentAlignment.MiddleCenter,
                BackColor          = Color.AliceBlue,
                Font               = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor          = Color.Black,
                Padding            = new Padding(0, 5, 0, 5),
                SelectionBackColor = Color.AliceBlue,
                SelectionForeColor = Color.Black,
                WrapMode           = DataGridViewTriState.False
            };
        }

        private static DataGridViewCellStyle GetDefaultCellStyle()
        {
            return new DataGridViewCellStyle
            {
                Alignment          = DataGridViewContentAlignment.MiddleCenter,
                BackColor          = Color.White,
                Font               = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor          = Color.Black,
                SelectionBackColor = Color.WhiteSmoke,
                SelectionForeColor = Color.Black,
                WrapMode           = DataGridViewTriState.False
            };
        } 

        private static DataGridViewCellStyle GetRowHeadersDefaultCellStyle()
        {
            return new DataGridViewCellStyle
            {
                Alignment          = DataGridViewContentAlignment.MiddleCenter,
                BackColor          = Color.White,
                Font               = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
                ForeColor          = SystemColors.WindowText,
                SelectionBackColor = SystemColors.Highlight,
                SelectionForeColor = SystemColors.HighlightText,
                WrapMode           = DataGridViewTriState.True,
            };
        }

        public TlDataGrid()
        {
            AllowUserToAddRows        = false;
            AllowUserToDeleteRows     = false;
            AllowUserToOrderColumns   = true;
            Anchor                    = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AutoGenerateColumns       = false;
            AutoSizeColumnsMode       = DataGridViewAutoSizeColumnsMode.Fill;
            BackgroundColor           = Color.White;
            BorderStyle               = BorderStyle.None;
            CellBorderStyle           = DataGridViewCellBorderStyle.Raised;
            Cursor                    = Cursors.Hand;     
            EnableHeadersVisualStyles = false;
            MultiSelect               = false;
            ReadOnly                  = true;
            RowHeadersVisible         = false;
            RowTemplate.Height        = 25;
            SelectionMode             = DataGridViewSelectionMode.FullRowSelect;

            ColumnHeadersDefaultCellStyle = GetColumnsHeaderDefaultStyle();
            ColumnHeadersHeightSizeMode   = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DefaultCellStyle              = GetDefaultCellStyle();
            RowHeadersDefaultCellStyle    = GetRowHeadersDefaultCellStyle();
        }

        public bool SelectRow(int index)
        {
            ClearSelection();

            for (var i = 0; i < Rows.Count; i++)
            {
                if (i == index)
                {
                    var row = Rows[i];

                    row.Selected = true;

                    CurrentCell = row.Cells[0];

                    return true;
                }
            }

            return false;
        }

        public bool SelectRow<T>(Func<T, bool> select)
        {
            ClearSelection();

            foreach (var rowObj in Rows)
            {
                if (rowObj is DataGridViewRow row && row.DataBoundItem is T obj && select(obj))
                {
                    row.Selected = true;

                    CurrentCell = row.Cells[0];

                    return true;
                }
            }

            return false;
        }
    }
}
