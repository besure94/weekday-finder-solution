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

    public int Day { get; }

    public Date(int month, int day)
    {
      _month = month;
      Day = day;
    }
  }
}