using System;

namespace Daybreaksoft.Extensions.TimeZone
{
    public static class TimeZoneFormat
    {
        public static string GetUtcOffset(string timeZoneId)
        {
            var timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

            return GetUtcOffset(timeZoneInfo);
        }

        public static string GetUtcOffset(TimeZoneInfo timeZoneInfo)
        {
            return timeZoneInfo == null ? "" : $"{(timeZoneInfo.BaseUtcOffset.Hours < 0 ? "-" : "+")}{Math.Abs(timeZoneInfo.BaseUtcOffset.Hours):00}:{Math.Abs(timeZoneInfo.BaseUtcOffset.Minutes):00}";
        }
    }
}
