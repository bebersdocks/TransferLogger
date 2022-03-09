using TransferLogger.BusinessLogic;

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
        public static void FillLookups(this TlDropDownList dropDownList, IEnumerable<Lookup> items)
        {
            dropDownList.ValueMember   = nameof(Lookup.Value);
            dropDownList.DisplayMember = nameof(Lookup.DisplayName);
            dropDownList.DataSource    = items.ToList();
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, IEnumerable<T> items, Func<T, Lookup> getLookup)
        {
            dropDownList.FillLookups(items.Select(i => getLookup(i)));
        }

        public static void FillLookups<T>(this TlDropDownList dropDownList, T? selectedValue = default) where T : Enum
        {
            var items = Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(e => new Lookup(Convert.ToInt32(e), e.ToString()));

            dropDownList.FillLookups(items);

            if (selectedValue != null)
                dropDownList.SelectedValue = Convert.ToInt32(selectedValue);
        }
    }
}
