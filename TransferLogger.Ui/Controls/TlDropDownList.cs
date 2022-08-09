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
        public static void FillLookups(this TlDropDownList dropDownList, IList<Lookup> items, Lookup? defaultValue = null)
        {
            if (defaultValue != null)
            {
                items = items.ToList(); // Use copy.

                items.Insert(0, defaultValue);
            }

            dropDownList.ValueMember   = nameof(Lookup.Value);
            dropDownList.DisplayMember = nameof(Lookup.DisplayName);
            dropDownList.DataSource    = items.ToList();
            dropDownList.SelectedIndex = defaultValue != null ? 0 : -1;
        }

        public static void FillLookups(this TlDropDownList dropDownList, IList<Lookup> items, int selectedValue, Lookup? defaultValue = null)
        {
            dropDownList.FillLookups(items, defaultValue);

            dropDownList.SelectedValue = selectedValue;
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, IList<Lookup> items, T selectedValue)
        {
            dropDownList.FillLookups(items, Convert.ToInt32(selectedValue), null);
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, Lookup? defaultValue = null) where T : Enum
        {
            dropDownList.FillLookups(EnumUtils.GetLookups<T>(), defaultValue);
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, int selectedValue, Lookup? defaultValue = null) where T : Enum
        {
            dropDownList.FillLookups(EnumUtils.GetLookups<T>(), Convert.ToInt32(selectedValue), defaultValue);
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, T selectedValue) where T : Enum
        {
            dropDownList.FillLookups<T>(Convert.ToInt32(selectedValue));
        }

        public static T? GetSelectedValue<T>(this TlDropDownList dropDownList) where T : struct
        {
            if (dropDownList.SelectedValue is not null && Enum.IsDefined(typeof(T), dropDownList.SelectedValue))
                return (T)dropDownList.SelectedValue;

            return null;
        }
    }
}
