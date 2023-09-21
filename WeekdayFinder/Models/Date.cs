namespace WeekdayFinder.Models
{

  public class Date
  {
    private int _month;
    public int Month
    {
      get { return _month; }
      set { _month = value; }
    }

    public int Day { get; set; }
    private int _year;

    public Date(int month, int day, int year)
    {
      _month = month;
      Day = day;
      _year = year;
    }

    public int GetYear()
    {
      return _year;
    }

    public void SetYear(int newValue)
    {
      _year = newValue;
    }
  }
}