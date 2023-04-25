using Spectre.Console;

namespace TMPS_lab2.Facade
{
    public class CalendarFacade
    {
        public void ShowEventsInCalendar(List<Event> events)
        {
            events.ForEach(e =>
            {
                var calendar = new Calendar(e.Year, e.Month);
                calendar.Culture("ro-RO");
                calendar.HeaderStyle(Style.Parse("lime italic"));
                calendar.AddCalendarEvent(e.Year, e.Month, e.Day);
                calendar.HighlightStyle(Style.Parse("red3_1 rapidblink"));
                calendar.Border = TableBorder.DoubleEdge;
                AnsiConsole.Write(calendar);
                AnsiConsole.WriteLine();
            });
        }
    }
}