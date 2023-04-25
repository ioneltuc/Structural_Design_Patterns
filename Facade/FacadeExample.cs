namespace TMPS_lab2.Facade
{
    public static class FacadeExample
    {
        public static void StartExample()
        {
            var facade = new CalendarFacade();

            facade.ShowEventsInCalendar(new List<Event>()
            {
                new Event(2023, 4, 27),
                new Event(2023, 5, 1),
                new Event(2023, 5, 9),
                new Event(2023, 6, 1),
            });
        }
    }
}