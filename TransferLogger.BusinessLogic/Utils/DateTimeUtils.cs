using System;

namespace TransferLogger.BusinessLogic.Utils
{
    public static class DateTimeUtils
    {
        public static string ToDisplayString(this DateTime dt)
        {
            return dt
                .ToLocalTime()
                .ToString("dd-MM-yyyy HH:mm") ?? string.Empty;
        }
    }
}
