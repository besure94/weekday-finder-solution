using System;

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
      DateTime dateValue = new DateTime(Year, Month, Day);
      string weekday = dateValue.ToString("dddd");
      return weekday;
    }
  }
}