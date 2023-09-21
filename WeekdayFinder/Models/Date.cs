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

    public Date(int month)
    {
      _month = month;
    }
  }
}