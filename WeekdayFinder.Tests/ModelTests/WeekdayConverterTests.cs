using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class WeekdayConverterTests
  {

    [TestMethod]
    public void WeekdayConverterConstructor_CreatesInstanceOfWeekdayConverter_WeekdayConverter()
    {
      WeekdayConverter newWeekdayConverter = new WeekdayConverter(2023, 9, 21);
      Assert.AreEqual(typeof(WeekdayConverter), newWeekdayConverter.GetType());
    }

    [TestMethod]
    public void WeekdayConverter_ReturnsYear_Int()
    {
      WeekdayConverter newWeekdayConverter = new WeekdayConverter(2023, 9, 21);
      int result = newWeekdayConverter.Year;
      Assert.AreEqual(2023, result);
    }

    [TestMethod]
    public void WeekdayConverter_SetsValueOfYear_Void()
    {
      WeekdayConverter newWeekdayConverter = new WeekdayConverter(2023, 9, 21);
      int newYear = 1953;
      newWeekdayConverter.Year = newYear;
      Assert.AreEqual(newYear, newWeekdayConverter.Year);
    }

    [TestMethod]
    public void WeekdayConverter_ReturnsMonth_Int()
    {
      WeekdayConverter newWeekdayConverter = new WeekdayConverter(2023, 9, 21);
      int result = newWeekdayConverter.Month;
      Assert.AreEqual(9, result);
    }

    [TestMethod]
    public void WeekdayConverter_SetsValueOfMonth_Void()
    {
      WeekdayConverter newWeekdayConverter = new WeekdayConverter(2023, 9, 21);
      int newMonth = 6;
      newWeekdayConverter.Month = newMonth;
      Assert.AreEqual(newMonth, newWeekdayConverter.Month);
    }

    [TestMethod]
    public void WeekdayConverter_ReturnsDay_Int()
    {
      WeekdayConverter newWeekdayConverter = new WeekdayConverter(2023, 9, 21);
      int result = newWeekdayConverter.Day;
      Assert.AreEqual(21, result);
    }

    [TestMethod]
    public void WeekdayConverter_SetsValueOfDay_Int()
    {
      WeekdayConverter newWeekdayConverter = new WeekdayConverter(2023, 9, 21);
      int newDay = 26;
      newWeekdayConverter.Day = newDay;
      Assert.AreEqual(newDay, newWeekdayConverter.Day);
    }

    [TestMethod]
    public void GetWeekdayForDate_ReturnsWeekdayForGivenDate_String()
    {
      WeekdayConverter inputtedDate = new WeekdayConverter(1920, 12, 25);
      string dateResult = inputtedDate.GetWeekdayForDate();
      Assert.AreEqual("Saturday", dateResult);
    }

    [TestMethod]
    public void GetWeekdayForDate_ChecksWeekdayConverterForValidDate_String()
    {
      WeekdayConverter inputtedDate = new WeekdayConverter(19941, 12, 23);
      string errorResult = inputtedDate.GetWeekdayForDate();
      Assert.AreEqual("Can't calculate weekday, please enter a valid date.", errorResult);
    }

  }
}