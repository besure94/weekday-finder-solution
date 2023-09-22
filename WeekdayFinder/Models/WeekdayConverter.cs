using System.Collections.Generic;

namespace WeekdayFinder.Models
{

  public class WeekdayConverter
  {

    public int Year { get; set; }
    public int Month { get; set; }
    public int Day { get; set; }

    public WeekdayConverter(int year, int month, int day)
    {
      Year = year;
      Month = month;
      Day = day;
    }

    public string GetWeekdayForDate()
    {
      if ((Year > 9999) || (Year < 0001) || ((Month > 12) || (Month < 1)) ||  ((Day > 31) || (Day < 1)))
      {
        return "Can't calculate weekday, please enter a valid date.";
      }
      else
      {
        DateTime dateValue = new DateTime(Year, Month, Day);
        string weekday = dateValue.ToString("dddd");
        return weekday;
      }
    }

  }
}