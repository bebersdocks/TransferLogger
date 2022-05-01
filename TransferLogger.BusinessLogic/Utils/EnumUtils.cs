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
            var memberInfo = value.GetType()
                .GetMember(value.ToString())
                .FirstOrDefault();

            if (memberInfo != null)
            {
                return memberInfo.GetCustomAttributes(typeof(T), false)
                    .Cast<T>()
                    .FirstOrDefault();
            }

            return null;
        }

        public static string GetDisplayName(this Enum value)
        {
            if (!Enum.IsDefined(value.GetType(), value))
                return string.Empty;
            else if (value.GetAttribute<StringValueAttribute>() is StringValueAttribute strValueAttr)
                return strValueAttr.Value;
            else
                return value.ToString();
        }

        public static List<Lookup> GetLookups<T>(IEnumerable<T> values) where T : Enum
        {
            return values
                .Select(e => new Lookup(Convert.ToInt32(e), e.GetDisplayName()))
                .ToList();
        }

        public static List<Lookup> GetLookups<T>() where T : Enum
        {
            var values = Enum.GetValues(typeof(T))
                .Cast<T>();

            return GetLookups(values);
        }
    }
}
