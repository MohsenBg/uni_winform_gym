using System;
using System.Globalization;

namespace GymApp.Utilities
{
    public static class PersianDateConverter
    {
        private static readonly PersianCalendar _persianCalendar = new PersianCalendar();

        public static DateTime ToPersianDateTime(DateTime dateTime)
        {
            int year = _persianCalendar.GetYear(dateTime);
            int month = _persianCalendar.GetMonth(dateTime);
            int day = _persianCalendar.GetDayOfMonth(dateTime);

            return new DateTime(year, month, day, dateTime.Hour, dateTime.Minute, dateTime.Second, _persianCalendar);
        }

        public static DateTime ToGregorianDateTime(DateTime persianDateTime)
        {
            int year = persianDateTime.Year;
            int month = persianDateTime.Month;
            int day = persianDateTime.Day;

            return _persianCalendar.ToDateTime(year, month, day, persianDateTime.Hour, persianDateTime.Minute, persianDateTime.Second, 0);
        }
    }
}