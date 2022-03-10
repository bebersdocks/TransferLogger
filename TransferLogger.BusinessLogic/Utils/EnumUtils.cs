using System;
using System.Collections.Generic;
using System.Linq;

using TransferLogger.Dal.Utils;

namespace TransferLogger.BusinessLogic.Utils
{
    public static class EnumUtils
    {
        public static T GetAttribute<T>(this Enum value) where T : Attribute
        {
            var enumType = value.GetType();
            var name = Enum.GetName(enumType, value);

            return enumType.GetField(name)
                .GetCustomAttributes(false)
                .OfType<T>()
                .SingleOrDefault();
        }

        public static string GetDisplayName(this Enum value)
        {
            if (value.GetAttribute<StringValueAttribute>() is StringValueAttribute strValueAttr)
                return strValueAttr.Value;
            else
                return value.ToString();
        }

        public static List<Lookup> GetLookups<T>() where T : Enum
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(e => new Lookup(Convert.ToInt32(e), e.GetDisplayName()))
                .ToList();
        }
    }
}
