namespace BookRoom.Infrastructure.Extensions
{
    public static class DateExtensions
    {
        public static IEnumerable<DateTime> Daily(this TimeSpan ts, DayOfWeek startDayOfWeek = DayOfWeek.Monday, DateTime? checkDay = null)
        {
            var compDate = checkDay ?? DateTime.UtcNow;
            var days = startDayOfWeek - compDate.DayOfWeek;
            days = days > 0 ? days - 7 : days;
            var startDate = compDate.AddDays(days);

            for (var i = 0; i < 7; i++)
            {
                yield return startDate.AddDays(i).Date + ts;
            }
        }

        public static IEnumerable<DateTime> DailyAt(this DateTime date)
        {
            for (int offset = 0; ; offset++)
            {
                yield return date.Date.AddDays(offset);
            }
        }

        public static DateTime LastMonday(this DateTime value)
        {
            var days = DayOfWeek.Monday - value.DayOfWeek;
            days = days > 0 ? days - 7 : days;

            return value.AddDays(days);
        }

        public static List<DateTime> GetDaysOfWeekOld(this DateTime value)
        {
            var days = new List<DateTime>();
            var lastMounday = value.LastMonday();

            for (int i=0; i < 7; i++)
            {
                days.Add(lastMounday.AddDays(i).Date);
            }

            return days;
        }


        public static IEnumerable<DateTime> GetDaysOfWeek(this DateTime value, DateTime? checkDay = null, DayOfWeek startDayOfWeek = DayOfWeek.Monday)
        {
            var days = new List<DateTime>();

            var compDate = checkDay ?? DateTime.UtcNow;
            var day = startDayOfWeek - compDate.DayOfWeek;
            day = day > 0 ? day - 7 : day;
            var startDate = compDate.AddDays(day);

            for (var i = 0; i < 7; i++)
            {
                days.Add(startDate.AddDays(i).Date);
            }

            return days;
        }


        // SetTime
        public static DateTime SetTime(this DateTime current, int hour)
        {
            return SetTime(current, hour, 0, 0, 0);
        }

        public static DateTime SetTime(this DateTime current, int hour, int minute)
        {
            return SetTime(current, hour, minute, 0, 0);
        }

        public static DateTime SetTime(this DateTime current, int hour, int minute, int second)
        {
            return SetTime(current, hour, minute, second, 0);
        }

        public static DateTime SetTime(this DateTime current, int hour, int minute, int second, int millisecond)
        {
            return new DateTime(current.Year, current.Month, current.Day, hour, minute, second, millisecond);
        }
    }
}
