using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class DateTimeTests
  {

    [TestMethod]
    public void DateTimeConstructor_CreatesInstanceOfDateTime_DateTime()
    {
      DateTime newDateTime = new DateTime(2023, 9, 21);
      Assert.AreEqual(typeof(DateTime), newDateTime.GetType());
    }

    [TestMethod]
    public void GetYear_ReturnsYear_Int()
    {
      int year = 2023;
      DateTime newDateTime = new DateTime(year, 9, 21);
      int result = newDateTime.Year;
      Assert.AreEqual(year, result);
    }

    [TestMethod]
    public void SetYear_SetsValueOfYear_Void()
    {
      DateTime newDateTime = new DateTime(2023, 9, 21);
      int newYear = 1953;
      newDateTime.Year = newYear;
      Assert.AreEqual(newYear, newDateTime.Year);
    }

    [TestMethod]
    public void GetMonth_ReturnsMonth_Int()
    {
      int month = 9;
      DateTime newDateTime = new DateTime(2023, month, 21);
      int result = newDateTime.Month;
      Assert.AreEqual(month, result);
    }

    [TestMethod]
    public void SetMonth_SetsValueOfMonth_Void()
    {
      DateTime newDateTime = new DateTime(2023, 9, 21);
      int newMonth = 6;
      newDateTime.Month = newMonth;
      Assert.AreEqual(newMonth, newDateTime.Month);
    }

    [TestMethod]
    public void GetDay_ReturnsDay_Int()
    {
      int day = 21;
      DateTime newDateTime = new DateTime(2023, 9, day);
      int result = newDateTime.GetDay();
      Assert.AreEqual(day, result);
    }

    [TestMethod]
    public void SetDay_SetsValueOfDay_Void()
    {
      DateTime newDateTime = new DateTime(2023, 9, 21);
      int newDay = 22;
      newDateTime.SetDay(newDay);
      Assert.AreEqual(newDay, newDateTime.GetDay());
    }

    [TestMethod]
    public void GetWeekdayForDate_ReturnsWeekdayForGivenDate_String()
    {
      DateTime inputtedDate = new DateTime(1920, 12, 25);
      string dateResult = inputtedDate.GetWeekdayForDate();
      Assert.AreEqual("Saturday", dateResult);
    }

  }
}