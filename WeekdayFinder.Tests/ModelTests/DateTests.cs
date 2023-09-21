using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class DateTests
  {

    [TestMethod]
    public void DateConstructor_CreatesInstanceOfDate_Date()
    {
      Date newDate = new Date(9);
      Assert.AreEqual(typeof(Date), newDate.GetType());
    }

    [TestMethod]
    public void GetMonth_ReturnsMonth_Int()
    {
      int month = 9;
      Date newDate = new Date(month);
      int result = newDate.Month;
      Assert.AreEqual(month, result);
    }

    [TestMethod]
    public void SetMonth_SetsValueOfMonth_Void()
    {
      Date newDate = new Date(9);
      int newMonth = 12;
      newDate.Month = newMonth;
      Assert.AreEqual(newMonth, newDate.Month);
    }

  }
}