using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TransferLogger.BusinessLogic;
using TransferLogger.BusinessLogic.Utils;

namespace TransferLogger.Ui.Controls
{
    public class TlDropDownList : ComboBox
    {
        public TlDropDownList()
        {
            BackColor     = Color.GhostWhite;
            Cursor        = Cursors.Hand;
            DropDownStyle = ComboBoxStyle.DropDownList;
            Width         = 325;
        }
    }

    public static class TlDropDownListExtensions
    {
        public static void FillLookups<T>(this TlDropDownList dropDownList, IEnumerable<Lookup> items)
        {
            dropDownList.ValueMember   = nameof(Lookup.Value);
            dropDownList.DisplayMember = nameof(Lookup.DisplayName);
            dropDownList.DataSource    = items.ToList();
            dropDownList.SelectedIndex = -1;
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, IEnumerable<Lookup> items, int selectedValue)
        {
            dropDownList.FillLookups<T>(items);

            dropDownList.SelectedValue = selectedValue;
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, IEnumerable<Lookup> items, T selectedValue)
        {
            dropDownList.FillLookups<T>(items);

            dropDownList.SelectedValue = Convert.ToInt32(selectedValue);
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, IEnumerable<T> items, Func<T, Lookup> getLookup)
        {
            dropDownList.FillLookups<T>(items.Select(i => getLookup(i)));
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList) where T : Enum
        {
            dropDownList.FillLookups<T>(EnumUtils.GetLookups<T>());
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, T selectedValue) where T : Enum
        {
            dropDownList.FillLookups(EnumUtils.GetLookups<T>(), selectedValue);
        }
    }
}
