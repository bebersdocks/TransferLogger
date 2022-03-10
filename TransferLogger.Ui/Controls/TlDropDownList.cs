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
        public static void FillLookups<T>(this TlDropDownList dropDownList, IEnumerable<Lookup> items, T? selectedValue = default)
        {
            dropDownList.ValueMember   = nameof(Lookup.Value);
            dropDownList.DisplayMember = nameof(Lookup.DisplayName);
            dropDownList.DataSource    = items.ToList();

            if (selectedValue != null)
                dropDownList.SelectedValue = Convert.ToInt32(selectedValue);
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, IEnumerable<T> items, Func<T, Lookup> getLookup)
        {
            dropDownList.FillLookups<T>(items.Select(i => getLookup(i)));
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, T? selectedValue = default) where T : Enum
        {
            dropDownList.FillLookups(EnumUtils.GetLookups<T>(), selectedValue);
        }
    }
}
