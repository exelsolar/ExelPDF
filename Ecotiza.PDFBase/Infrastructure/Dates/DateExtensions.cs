using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Ecotiza.PDFBase.Infrastructure.Dates.Enums;
using Ecotiza.PDFBase.Infrastructure.Objects;
using Ecotiza.PDFBase.Infrastructure.Enums;

namespace Ecotiza.PDFBase.Infrastructure.Dates
{
    public static class DateExtensions
    {
        public static string ToDateStringDb(this DateTime dateTime)
        {
            return dateTime.ToString("MM/dd/yyyy");
        }

        public static string ToDateTimeStringDb(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string ToTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss");
        }

        public static string ToDateString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy");
        }

        public static string ToDateString(this DateTime? dateTime)
        {
            return dateTime.IsNotNull() ? dateTime.Value.ToString("dd/MM/yyyy") : string.Empty;
        }

        public static string ToDateTimeString(this DateTime dateTime)
        {
            return dateTime.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string ToDateTimeString(this DateTime? dateTime)
        {
            return dateTime.IsNotNull()?  dateTime.Value.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
        }

        public static DateTime DateStringToDateTimeDb(this string date)
        {
            return DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }

        public static DateTime DateTimeStringToDateTimeDb(this string dateTime)
        {
            return DateTime.ParseExact(dateTime, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }

        public static DateTime DateStringToDateTime(this string date)
        {
            return DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public static DateTime DateTimeStringToDateTime(this string dateTime)
        {
            return DateTime.ParseExact(dateTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        }

        public static DateTime? DateTimeStringToDateTimeNullable(this string dateTime)
        {
            try
            {
                return DateTime.ParseExact(dateTime, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }

        public static DateTime? DateTimeStringToDateNullable(this string dateTime)
        {
            try
            {
                return DateTime.ParseExact(dateTime, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch
            {
                return null;
            }
        }
        public static string DateTimeStringToDateString(this string date)
        {
            return date.Split(' ').First();
        }

        public static DateTime Today()
        {
            return DateTime.Today;
        }

        public static int Age(this DateTime dateTime)
        {
            return Today().Year - dateTime.Year;
        }

        public static bool IsGreaterThanToday(this DateTime dateTime)
        {
            return dateTime.Date > Today().Date;
        }

        public static bool IsLessThanToday(this DateTime dateTime)
        {
            return dateTime.Date < Today().Date;
        }

        public static bool IsLessThanToday(this List<DateTime> dateTimes)
        {
            return dateTimes.All(dateTime => dateTime.IsLessThanToday());
        }

        public static bool IsGreaterThan(this DateTime dateTime1, DateTime dateTime2)
        {
            return dateTime1.Date > dateTime2.Date;
        }

        public static bool IsValidDayOfWeek()
        {
            var dayOfWeek = (int) DateTime.Now.DayOfWeek;
            var monday = EDayWeek.Monday.GetValue();
            var friday = EDayWeek.Friday.GetValue();
            return monday <= dayOfWeek && friday >= dayOfWeek;
        }

        public static bool IsValidHour()
        {
            var hourStart = DateTime.ParseExact("08:00:00", "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
            var hourEnd = DateTime.ParseExact("20:00:00", "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
            var hourToday = DateTime.ParseExact(DateTime.Now.ToTimeString(), "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
            return hourStart <= hourToday && hourEnd >= hourToday;
        }

        public static int CountDaysOfDates(this DateTime dateTime1, DateTime dateTime2)
        {
            TimeSpan timeSpan = new TimeSpan();
            if (dateTime1 > dateTime2)
                timeSpan = dateTime1 - dateTime2;
            else
                timeSpan = dateTime2 - dateTime1;
            return ((int)timeSpan.TotalDays) < 0 ? 0 : ((int)timeSpan.TotalDays);
        }
    }
}