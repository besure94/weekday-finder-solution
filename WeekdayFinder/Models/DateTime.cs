using System;

namespace WeekdayFinder.Models
{

  public class DateTime
  {
    private int _year;
    public int Year
    {
      get { return _year; }
      set { _year = value; }
    }

    public int Month { get; set; }
    private int _day;

    public DateTime(int year, int month, int day)
    {
      _year = year;
      Month = month;
      _day = day;
    }

    public int GetDay()
    {
      return _day;
    }

    public void SetDay(int newValue)
    {
      _day = newValue;
    }

    public string GetWeekdayForDate()
    {
      DateTime? dateValue = new DateTime(1920, 12, 25);
      string weekday = dateValue.ToString("dddd");
      return weekday;
    }
  }
}