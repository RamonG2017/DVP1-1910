using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ReadAllLines used to print out text file of ASCII art

// Name: Ramon Gonzalez Arguello
// Date: October 2019   
// CE Name: Coding Exercise 4 - Age Convert

/*
 * Synopsis: Asks for the user's name and age then calculate the age in days,
 * hours, minutes and seconds. This program takes into account the amount of
 * leap years that have passed.
 */

namespace DVP1
{
  public class CE4_AgeConvert
  {
    public static void AgeConvertStart()
    {
      Console.Clear();

      /*
       * define the path of the text file that is going to be accessed
       * 
       * NOTE: the file path must be changed to whatever the path is of the
       * file in each individual computer.
       */
      string filePath = @"/Users/ramongonzalezarguello/Documents/GitHub/" +
                        @"dvp1-1910-RamonG2017/HeaderTextFiles/" +
                        @"AgeConvertHeader.txt";

      //create a string list that stores every individual line of the txt file
      List<string> fileLines = File.ReadAllLines(filePath).ToList();

      //print each line of the string list
      foreach (string line in fileLines)
      {
        Console.WriteLine(line);
      }

      Console.WriteLine("\r\n");

      Console.WriteLine("Welcome to AgeConvert:");

      string name = CE7_Validation.StringValidation(
                                         "To begin, please enter your name...");

      Console.WriteLine("\r\n");

      int userAge = CE7_Validation.IntegerValidation("Thank you " + name +
                                                   " Now I know this may be " +
                                              "personal, but what's your age?");

      //store the age in days, assign the return value from the called method
      int userAgeInDays = userAge_Days(userAge);

      //store the age in hours, assign the return value from the called method
      int userAgeInHours = userAge_Hours(userAge);

      //store the age in minutes, assign the return value from the called method
      int userAgeInMinutes = userAge_Minutes(userAge);

      //store the age in seconds, assign the return value from the called method
      long userAgeInSeconds = userAge_Seconds(userAge);

      Console.WriteLine("\r\n");

      Console.WriteLine(userAge + " years, Fantastic! Next time someone " +
                        "asks, try answering with:");

      Console.WriteLine(String.Format("{0:n0}", userAgeInDays) + " days -or-");

      Console.WriteLine(String.Format("{0:n0}", userAgeInHours) +
                                      " hours -or-");

      Console.WriteLine(String.Format("{0:n0}", userAgeInMinutes) +
                                      " minutes -or-");

      Console.WriteLine(String.Format("{0:n0}", userAgeInSeconds) + " seconds");

      Console.Write("\r\n");

      Console.WriteLine("=============================================" +
                        "=========================");

      Console.Write("Press any key to return to the main menu: ");
    }

    private static int userAge_Days(int userAge)
    {
      //variable for storing the amout of leap years that have passed in days
      int leapYearDays;

      //variable that stores the user's age in days
      int userAgeInDays;

      //calculate the amount of leap years that have happened in days
      leapYearDays = userAge / 4;

      //calculate the user age in days taking into account leap years
      userAgeInDays = userAge * 365 + leapYearDays;

      //return the user's age in days
      return userAgeInDays;
    }

    private static int userAge_Hours(int userAge)
    {
      //variable that stores the user's age in hours
      int userAgeInHours;

      ////calculate the user age in hours based on the age in days
      userAgeInHours = userAge_Days(userAge) * 24;

      //return the user's age in hours
      return userAgeInHours;
    }

    private static int userAge_Minutes(int userAge)
    {
      //variable that stores the user's age in minutes
      int userAgeInMinutes;

      //calculate the user age in minutes based on the age in hours
      userAgeInMinutes = userAge_Hours(userAge) * 60;

      //return the user's age in minutes
      return userAgeInMinutes;
    }

    private static long userAge_Seconds(int userAge)
    {
      //variable that stores the user's age in seconds
      long userAgeInSeconds;

      //calculate the user age in seconds based on age in minutes
      userAgeInSeconds = userAge_Minutes(userAge) * 60;

      //return the user's age in seconds
      return userAgeInSeconds;
    }
  }
}