/******************************************************************************
filename   FinalProject.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 10         
due date   29/08/2019

 Brief Description:
  calculates the profit that will  be made by buying packages of cookies and
  then selling them individually.
******************************************************************************/

using System;
using System.Collections.Generic;

namespace GonzalezArguello_Ramon_FinalProject
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Cookie Counter program!");

      Console.WriteLine("We are going to calculate the profit you will " +
                        "make when selling individual cookies out of" +
                        "a pack of cookies.");

      Console.WriteLine("Please enter a comma separated list of " +
                        "types/flavours of each cookie package you are " +
                        "going to buy:");

        //store the cookie types
      string cookieType = Console.ReadLine();

        //check for null or whitespace input
      while (string.IsNullOrWhiteSpace(cookieType))
      {
        Console.WriteLine("\r\nPlease do not leave this blank!");

        Console.WriteLine("Please enter a comma separated list of " +
                        "types/flavours of each cookie package you are " +
                        "going to buy:");

          //store the cookie types
        cookieType = Console.ReadLine();
      }

        /*
         * make the string into a string array with elements being stored
         * after any comma
         */
      string[] cookieArray = cookieType.Split(',');

        //decimal array that stores the return value of the cookie cost function
      decimal[] cookiePrices = PromptCookieCosts(cookieArray);

        /*
         * decimal that stores the total price of the cookies based on
         * the calculations made in the total cookie cost function
         */
      decimal totalCookiePrice = TotalCookieCost(cookiePrices);

      Console.WriteLine("Please enter the number of individual cookies " +
                        "that are in each package:");

        //store the number of cookies per package the user gave
      string numberOfCookiesString = Console.ReadLine();

        /*
         * store the number of cookies per package the user gave as an int
         * then validate if the value given was indeed an integer
         */
      int numberOfCookies = 0;

      while (!(int.TryParse(numberOfCookiesString, out numberOfCookies)))
      {
        Console.WriteLine("\r\nPlease only enter a positive whole numbers");


        Console.WriteLine("Please enter the number of individual cookies " +
                        "that are in each package:");

          //store the number of cookies per package the user gave
        numberOfCookiesString = Console.ReadLine();
      }

      Console.WriteLine("What is the selling price for 1 individual cookie?");

        //store the price per cookie
      string priceIndividualString = Console.ReadLine();

        /*
         * store the price per cookie the user gave as a decimal
         * then validate if the value given was indeed a decimal
         */
      decimal priceIndividual = 0;

      while (!(decimal.TryParse(priceIndividualString, out priceIndividual)))
      {
        Console.WriteLine("\r\nPlease only enter a positive decimal integer");


        Console.WriteLine("What is the selling price for 1 individual cookie?");

          //store the price per cookie
        priceIndividualString = Console.ReadLine();
      }

        //store the returned value of the called function as a decimal
      decimal amountSoldFor = AmountSoldFor(cookieArray, numberOfCookies,
                                           priceIndividual);

        //calculate the profits to be made
      decimal profits = amountSoldFor - totalCookiePrice;

      Console.WriteLine("You will make $" + profits + ", if you sell all " +
                        cookieArray.Length + " cookie types, assuming each " +
                        "package of cookies contains " + numberOfCookies +
                        " pieces for $" + priceIndividual + " per cookie");
    }

    public static decimal[] PromptCookieCosts(string[] cookieArray)
    {
        //create a new decimal array that witholds the cookie prices
      decimal[] cookiePrices = new decimal[cookieArray.Length];

      for (int i = 0; i < cookieArray.Length; i++)
      {
        Console.WriteLine("Please enter the cost of the " +
                          cookieArray[i].Trim() + " cookie package:");

          //store the price inputed
        string priceString = Console.ReadLine();

          //store the price as a decimal and then validate it is a decimal
        decimal price = 0;

        while (!(decimal.TryParse(priceString, out price)))
        {
          Console.WriteLine("\r\nPlease only enter a positive decimal integer");


          Console.WriteLine("Please enter the cost of the " +
                            cookieArray[i].Trim() + " cookie package:");

            //store the amount of money being converted
          priceString = Console.ReadLine();
        }

          //assign the price inputed to the current index
        cookiePrices[i] = price;
      }

        //return the cookie price array
      return cookiePrices;
    }

    public static decimal TotalCookieCost(decimal[] prices)
    {
        //store the total cost of the cookies
      decimal totalCookieCost = 0;

      for (int i = 0; i < prices.Length; i++)
      {
          /*
           * calculate the total cost by adding the price inside each
           * index of the array
           */
        totalCookieCost = totalCookieCost + prices[i];
      }

        //return the total cost of the cookies to MAIN
      return totalCookieCost;
    }

    public static decimal AmountSoldFor(string[] cookieArray,
                                        int cookiePerPackage,
                                        decimal individualPrice)
    {
        //calculate the amount the cookies are being sold for
      decimal amountSoldFor = cookieArray.Length *
                              (cookiePerPackage * individualPrice);

        //return the amount the cookies sold for to MAIN
      return amountSoldFor;
    }
  }
}

/*******************************************************************************
Test #1 results:
  Welcome to the Cookie Counter program!
  We are going to calculate the profit you will make when selling individual
  cookies out ofa pack of cookies.
  Please enter a comma separated list of types/flavours of each cookie package
  you are going to buy:
  Chocolate,    Sugar, Snicker Doodle
  Please enter the cost of the Chocolate cookie package:
  7.00
  Please enter the cost of the Sugar cookie package:


  Please only enter a positive decimal integer
  Please enter the cost of the Sugar cookie package:
  2.50
  Please enter the cost of the Snicker Doodle cookie package:
  6.50
  Please enter the number of individual cookies that are in each package:


  Please only enter a positive whole numbers
  Please enter the number of individual cookies that are in each package:
  10
  What is the selling price for 1 individual cookie?
  1.00
  You will make $14.00, if you sell all 3 cookie types, assuming each package of
  cookies contains 10 pieces for $1.00 per cookie

*******************************************************************************/

/*******************************************************************************
Test #2 results:
  Welcome to the Cookie Counter program!
  We are going to calculate the profit you will make when selling individual
  cookies out ofa pack of cookies.
  Please enter a comma separated list of types/flavours of each cookie package
  you are going to buy:
  Butter, Frosted, Sprinkles, Chocolate Chip
  Please enter the cost of the Butter cookie package:
  4.00
  Please enter the cost of the Frosted cookie package:
  5.40
  Please enter the cost of the Sprinkles cookie package:
  4.78
  Please enter the cost of the Chocolate Chip cookie package:
  6.99
  Please enter the number of individual cookies that are in each package:
  12
  What is the selling price for 1 individual cookie?
  1.25
  You will make $38.83, if you sell all 4 cookie types, assuming each package of
  cookies contains 12 pieces for $1.25 per cookie

*******************************************************************************/
