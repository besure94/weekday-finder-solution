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
      Date newDate = new Date(9, 21);
      Assert.AreEqual(typeof(Date), newDate.GetType());
    }

    [TestMethod]
    public void GetMonth_ReturnsMonth_Int()
    {
      int month = 9;
      Date newDate = new Date(month, 21);
      int result = newDate.Month;
      Assert.AreEqual(month, result);
    }

    [TestMethod]
    public void SetMonth_SetsValueOfMonth_Void()
    {
      Date newDate = new Date(9, 21);
      int newMonth = 12;
      newDate.Month = newMonth;
      Assert.AreEqual(newMonth, newDate.Month);
    }

    [TestMethod]
    public void GetDay_ReturnsDay_Int()
    {
      int day = 21;
      Date newDate = new Date(9, day);
      int result = newDate.Day;
      Assert.AreEqual(day, result);
    }

    [TestMethod]
    public void SetDay_SetsValueOfDay_Void()
    {
      Date newDate = new Date(9, 21);
      int newDay = 6;
      newDate.Day = newDay;
      Assert.AreEqual(newDay, newDate.Day);
    }

  }
}