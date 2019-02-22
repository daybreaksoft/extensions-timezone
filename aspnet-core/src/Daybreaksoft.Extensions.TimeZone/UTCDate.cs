using System;

namespace Daybreaksoft.Extensions.TimeZone
{
    public struct UtcDate
    {
        private DateTime _date;

        public UtcDate(DateTime date)
        {
            _date = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0, DateTimeKind.Utc);
        }

        public int Year => _date.Year;

        public int Month => _date.Month;

        public int Day => _date.Day;

        public int Hour => _date.Hour;

        public int Minute => _date.Minute;

        public int Second => _date.Second;

        public DateTime AddYears(int value)
        {
            return _date.AddYears(value);
        }

        public DateTime AddMonths(int value)
        {
            return _date.AddMonths(value);
        }

        public DateTime AddDays(int value)
        {
            return _date.AddDays(value);
        }

        public DateTime AddHours(int value)
        {
            return _date.AddHours(value);
        }

        public DateTime AddMinutes(int value)
        {
            return _date.AddMinutes(value);
        }

        public DateTime AddSeconds(int value)
        {
            return _date.AddSeconds(value);
        }

        public override string ToString()
        {
            return _date.ToString("0");
        }

        public DateTime ToDateTime()
        {
            return _date;
        }

        public static implicit operator DateTime(UtcDate value)
        {
            return value._date;
        }
    }
}
