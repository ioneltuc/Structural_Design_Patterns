namespace TMPS_lab2.Facade
{
    public class Event
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Event(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}