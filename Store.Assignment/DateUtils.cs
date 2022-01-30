namespace Store.Assignment
{
    public static class DateUtils
    {
        public static int GetDaysBetween(DateTime from, DateTime to)
        {
            var timeSpan = (to.Date - from.Date);

            return timeSpan.Days;
        }

        public static bool IsWeekend(DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
