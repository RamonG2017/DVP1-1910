/******************************************************************************
filename   List.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 08         
due date   29/08/2019

 Brief Description:
  Keeps track of locations that the user will be traveling to in the next year.
  The user can type in any amount of locations. Once they are done, the program
  will tell them the total number of trips they are taking and output the
  locations.
******************************************************************************/

using System;
using System.Collections.Generic;

namespace GonzalezArguello_Ramon_Lists
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello, welcome to my program. In this program you're" +
                        " going to be asked places that you will be " +
                        "travelling to in the next year.");

        //list that will store the locations entered by the user
      List<string> locationsList = new List<string>();

      Console.WriteLine("\r\nPlease enter a location that you would " +
                        "like to travel to:");

        //stores the inputed location the user will travel to
      string locationString = Console.ReadLine();

        //check for null or whitespace input
      while (string.IsNullOrWhiteSpace(locationString))
      {
        Console.WriteLine("\r\nPlease do not leave this blank!");

        Console.WriteLine("Please enter a location that you would " +
                        "like to travel to:");

          //stores the inputed location the user will travel to
        locationString = Console.ReadLine();
      }

        //insert the travel location as the first item in the list
      locationsList.Insert(0, locationString);

      Console.WriteLine("\r\nWould you like to add another location?");

        //store the yes or no choice of the user
      string choice = Console.ReadLine();

        //check for null or whitespace input
      while (string.IsNullOrWhiteSpace(choice))
      {
        Console.WriteLine("\r\nPlease do not leave this blank!");

        Console.WriteLine("Please enter a location that you would " +
                        "like to travel to:");

          //store the yes or no choice of the user
        choice = Console.ReadLine();
      }

        //check if the user is inputing yes or no
      while (!(choice == "no" || choice == "No" || choice == "NO") &&
             !(choice == "yes" || choice == "Yes" || choice == "YES"))
      {
        Console.WriteLine("\r\nPlease just answer yes or no.");

        Console.WriteLine("Would you like to add another location?");

          //store the yes or no choice of the user
        choice = Console.ReadLine();
      }
      

      while (choice == "yes" || choice == "Yes" || choice == "YES")
      {
        Console.WriteLine("\r\nPlease enter a location that you would " +
                       "like to travel to:");

          //stores the inputed location the user will travel to
        locationString = Console.ReadLine();

          //check for null or whitespace input
        while (string.IsNullOrWhiteSpace(locationString))
        {
          Console.WriteLine("\r\nPlease do not leave this blank!");

          Console.WriteLine("Please enter a location that you would " +
                          "like to travel to:");

            //stores the inputed location the user will travel to
          locationString = Console.ReadLine();
        }

          //insert the travel location at the next location in the list
        locationsList.Add(locationString);

        if (choice == "no" || choice == "No" || choice == "NO")
        {
          break;
        }

        Console.WriteLine("Would you like to add another location?");

          //store the yes or no choice of the user
        choice = Console.ReadLine();

          //check if the user is inputing yes or no
        while (!(choice == "no" || choice == "No" || choice == "NO") &&
             !(choice == "yes" || choice == "Yes" || choice == "YES"))
        {
          Console.WriteLine("\r\nPlease just answer yes or no.");

          Console.WriteLine("Would you like to add another location?");

            //store the yes or no choice of the user
          choice = Console.ReadLine();
        }
      }

        /*
         * call the custom fuction to print out how many trips and where the
         * user is going that year
         */
      TripOut(locationsList);

      Console.WriteLine("Thank you for using my program and safe travels!");
    }

    public static void TripOut(List<string> locationList)
    {
      Console.WriteLine("You will take " + locationList.Count +
                        " trips this year");

      for (int i = 0; i < locationList.Count; i++)
      {
        Console.WriteLine("You will visit " + locationList[i] + " this year.");
      }
    }

  }
}

/*******************************************************************************
Test #1 results:
  Hello, welcome to my program. In this program you're going to be asked
  places that you will be travelling to in the next year.

  Please enter a location that you would like to travel to:
  Italy

  Would you like to add another location?
  Yeah

  Please just answer yes or no.
  Would you like to add another location?
  Yes

  Please enter a location that you would like to travel to:
  England
  Would you like to add another location?
  No
  You will take 2 trips this year
  You will visit Italy this year.
  You will visit England this year.
  Thank you for using my program and safe travels!

*******************************************************************************/

/*******************************************************************************
Test #2 results:
  Hello, welcome to my program. In this program you're going to be asked
  places that you will be travelling to in the next year.

  Please enter a location that you would like to travel to:


  Please do not leave this blank!
  Please enter a location that you would like to travel to:
  San Diego

  Would you like to add another location?
  Yes

  Please enter a location that you would like to travel to:
  Hollywood
  Would you like to add another location?
  yes

  Please enter a location that you would like to travel to:
  Las Vegas
  Would you like to add another location?
  YES

  Please enter a location that you would like to travel to:
  New York
  Would you like to add another location?
  no
  You will take 4 trips this year
  You will visit San Diego this year.
  You will visit Hollywood this year.
  You will visit Las Vegas this year.
  You will visit New York this year.
  Thank you for using my program and safe travels!

*******************************************************************************/
