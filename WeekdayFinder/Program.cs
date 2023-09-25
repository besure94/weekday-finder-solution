using System;
using WeekdayFinder.Models;
using System.Collections.Generic;

namespace WeekdayFinder
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome!");
      Console.WriteLine("Would you like to enter any date and find out what day of the week it was? You can find out below!");
      Console.WriteLine("Please enter a year:");
      string inputtedYear = Console.ReadLine();
      Console.WriteLine("Please enter a month:");
      string inputtedMonth = Console.ReadLine();
      Console.WriteLine("Please enter a day:");
      string inputtedDay = Console.ReadLine();
      int userYear = int.Parse(inputtedYear);
      int userMonth = int.Parse(inputtedMonth);
      int userDay = int.Parse(inputtedDay);
      WeekdayConverter date = new WeekdayConverter(userYear, userMonth, userDay);
      ConfirmOrEditDate(date);
    }

    static void ConfirmOrEditDate(WeekdayConverter date)
    {
      Console.WriteLine("Please confirm that you entered in your date correctly:");
      Console.WriteLine($"{date.Year}");
      Console.WriteLine($"{date.Month}");
      Console.WriteLine($"{date.Day}");
      Console.WriteLine("Is that correct? Enter 'yes' to continue, or 'no' to re-enter the date.");
      string userInput = Console.ReadLine();
      if (userInput == "yes" || userInput == "Yes")
      {
        GetWeekdayForDate(date);
      }
      else
      {
        Console.WriteLine("Let's fix your date. Please enter the year, month, and day again!");
        Console.WriteLine("Please enter a year:");
        string userYear = Console.ReadLine();
        Console.WriteLine("Please enter a month:");
        string userMonth = Console.ReadLine();
        Console.WriteLine("Please enter a day:");
        string userDay = Console.ReadLine();
        date.Year = int.Parse(userYear);
        date.Month = int.Parse(userMonth);
        date.Day = int.Parse(userDay);
        ConfirmOrEditDate(date);
      }
    }

    static void GetWeekdayForDate(WeekdayConverter date)
    {
      string result = date.GetWeekdayForDate();
      Console.WriteLine("-----------------------------------------------------");
      Console.WriteLine("The weekday for this date was: " + result);
      Console.WriteLine("-----------------------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new date (new)?");
      Console.WriteLine("Otherwise, you can enter 'quit' to exit this program.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "quit" || userResponse == "Quit")
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}