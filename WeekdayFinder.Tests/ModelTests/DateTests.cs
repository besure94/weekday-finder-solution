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
      Date newDate = new Date();
      Assert.AreEqual(typeof(Date), newDate.GetType());
    }

  }
}