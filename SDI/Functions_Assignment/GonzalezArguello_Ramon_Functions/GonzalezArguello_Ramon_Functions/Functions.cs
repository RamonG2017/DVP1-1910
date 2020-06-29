/******************************************************************************
filename   Functions.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 07         
due date   29/08/2019

 Brief Description:
  Program that utilizes functions to solve 3 problems.
******************************************************************************/

using System;

namespace GonzalezArguello_Ramon_Functions
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      /*************************************************************************
         Problem #1: Currency Converter

         Description:
           	This program will convert Euros to American Dollars.
       ************************************************************************/

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #1: Currency Converter");
      Console.WriteLine("\r\n");

      Console.WriteLine("How much money would you like to convert to USD?");

        //store the inputed amount of money that is going to be converted
      string moneyString = Console.ReadLine();

        /*
         * variable used to store the money being converted and validate it
         * as a decimal
         */
      decimal money = 0;

      while (!(decimal.TryParse(moneyString, out money)))
      {
        Console.WriteLine("\r\nPlease enter a number");


        Console.WriteLine("How much money would you like to convert to USD?");

          //store the amount of money being converted
        moneyString = Console.ReadLine();
      }

        //call the EuroConverter fucntion and store the conversion
      decimal conversion = EuroConverter(money);

      Console.WriteLine(decimal.Round(money, 2) + " euros converted to " +
                        "dollars is: $" + decimal.Round(conversion, 2));

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");


      /*************************************************************************
      Test #1 results:
      ----------------------------------------------------
      Problem #1: Currency Converter


      How much money would you like to convert to USD?
      5.50
      5.50 euros converted to dollars is: $6.38
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Currency Converter


      How much money would you like to convert to USD?
      15.32
      15.32 euros converted to dollars is: $17.77
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Currency Converter


      How much money would you like to convert to USD?
      27.27
      27.27 euros converted to dollars is: $31.63
      ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
         Problem #2: Astronomical

         Description:
           	converts the users weight on earth to their weight on another planet
       ************************************************************************/

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #2: Astronomical");
      Console.WriteLine("\r\n");

        //variable used to store the percentage of weight of the chosen planet
      decimal weightOnChosenPlanet = 0;

      Console.WriteLine("How much do you weigh on Earth?");

        //store the weight of the user on Earth
      string weightEarthString = Console.ReadLine();

        //store the weight of the user on earth as an int and validate it
      int weightEarth = 0;

      while (!(int.TryParse(weightEarthString, out weightEarth)))
      {
        Console.WriteLine("\r\nPlease enter a number");


        Console.WriteLine("How much do you weigh on Earth?");

        //store the weight of the user on Earth
        weightEarthString = Console.ReadLine();
      }

      string[] planets = {"Mercury", "Venus", "Earth", "Mars", "Jupiter",
                          "Saturn", "Uranus", "Neptune" };

      Console.WriteLine("Please choose one of the following planets:");

      for (int i = 1; i <= planets.Length; i++)
      {
        Console.WriteLine(i + ". " + planets[i - 1]);
      }

        //store the choice of planet
      string choiceString = Console.ReadLine();

        //store and validate the choice as an int
      int choice = 0;

      while (!(int.TryParse(choiceString, out choice))
             || (choice <= 0 || choice > 8))
      {
        Console.WriteLine("\r\nPlease enter a number and make sure it is" +
                          " between 1 and 8");


        Console.WriteLine("Please choose one of the following planets:");

        for (int i = 1; i <= planets.Length; i++)
        {
          Console.WriteLine(i + ". " + planets[i - 1]);
        }

          //store the choice of planet 
        choiceString = Console.ReadLine();
      }

       /*
        * conditional block used to assign the conversion value to the
        * weightOnChosenPlanet variable that is going to be used as an argument
        * when calling the MassConverted function
        */
      if (choice == 1 || choice == 4)
      {
        weightOnChosenPlanet = 0.38m;
      }
      else if (choice == 2)
      {
        weightOnChosenPlanet = 0.91m;
      }
      else if (choice == 3)
      {
        weightOnChosenPlanet = 1.00m;
      }
      else if (choice == 5)
      {
        weightOnChosenPlanet = 2.34m;
      }
      else if (choice == 6)
      {
        weightOnChosenPlanet = 0.93m;
      }
      else if (choice == 7)
      {
        weightOnChosenPlanet = 0.93m;
      }
      else
      {
        weightOnChosenPlanet = 1.12m;
      }

        //variable that stores the return value from the called function
      decimal weightConverted = MassConverter(weightEarth,
                                              weightOnChosenPlanet);

      Console.WriteLine("\r\nOn Earth you weigh " + weightEarth +
                        " lbs, but on " + planets[choice - 1] +
                        " you would weight " +  weightConverted + " lbs.");

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
      Test #2 results:
      ----------------------------------------------------
      Problem #2: Astronomical


      How much do you weigh on Earth?
      160
      Please choose one of the following planets:
      1. Mercury
      2. Venus
      3. Earth
      4. Mars
      5. Jupiter
      6. Saturn
      7. Uranus
      8. Neptune
      6

      On Earth you weigh 160 lbs, but on Saturn you would weight 148.80 lbs.
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #2: Astronomical


      How much do you weigh on Earth?
      210
      Please choose one of the following planets:
      1. Mercury
      2. Venus
      3. Earth
      4. Mars
      5. Jupiter
      6. Saturn
      7. Uranus
      8. Neptune
      9

      Please enter a numbern and make sure it is between 1 and 8
      Please choose one of the following planets:
      1. Mercury
      2. Venus
      3. Earth
      4. Mars
      5. Jupiter
      6. Saturn
      7. Uranus
      8. Neptune
      5

      On Earth you weigh 210 lbs, but on Jupiter you would weight 491.40 lbs.
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #2: Astronomical


      How much do you weigh on Earth?
      one sixty

      Please enter a number
      How much do you weigh on Earth?
      160
      Please choose one of the following planets:
      1. Mercury
      2. Venus
      3. Earth
      4. Mars
      5. Jupiter
      6. Saturn
      7. Uranus
      8. Neptune
      two

      Please enter a number and make sure it is between 1 and 8
      Please choose one of the following planets:
      1. Mercury
      2. Venus
      3. Earth
      4. Mars
      5. Jupiter
      6. Saturn
      7. Uranus
      8. Neptune
      2

      On Earth you weigh 160 lbs, but on Venus you would weight 145.60 lbs.
      ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
         Problem #3: Dramatic Discounts

         Description:
           	user will give the program a price and it will tell the user what
            the cost will be with different discounts applied.
       ************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #3: Dramatic Discounts");
      Console.WriteLine("\r\n");

      decimal[] discountPercentages = { 5.00m, 10.00m, 15.00m,
                                        20.00m, 25.00m, 30.00m };

      Console.WriteLine("What is the price of your item?");

        //store the price of the item
      string itemPriceString = Console.ReadLine();

        //store and validate that the price is a decimal
      decimal itemPrice = 0;

      while (!(decimal.TryParse(itemPriceString, out itemPrice)))
      {
        Console.WriteLine("\r\nPlease enter a number");


        Console.WriteLine("What is the price of your item?");

          //store the price of the item
        itemPriceString = Console.ReadLine();
      }

      for (int i = 0; i < discountPercentages.Length; i++)
      {
          //call the DiscountCalc function and store the return on the variable
        decimal priceAfterDiscount = DiscountCalc(itemPrice,
                                                  discountPercentages[i]);

        Console.WriteLine("$" + itemPrice + " with a " +
                          decimal.Round(discountPercentages[i],0) + "% is $" +
                          decimal.Round(priceAfterDiscount, 2));
      }

      Console.WriteLine("----------------------------------------------------");

      /*************************************************************************
       Test #3 results:
        ----------------------------------------------------
        Problem #3: Dramatic Discounts


        What is the price of your item?
        10.00
        $10.00 with a 5% is $9.50
        $10.00 with a 10% is $9.00
        $10.00 with a 15% is $8.50
        $10.00 with a 20% is $8.00
        $10.00 with a 25% is $7.50
        $10.00 with a 30% is $7.00
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Dramatic Discounts


        What is the price of your item?
        17.99
        $17.99 with a 5% is $17.09
        $17.99 with a 10% is $16.19
        $17.99 with a 15% is $15.29
        $17.99 with a 20% is $14.39
        $17.99 with a 25% is $13.49
        $17.99 with a 30% is $12.59
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Dramatic Discounts


        What is the price of your item?
        27.27
        $27.27 with a 5% is $25.91
        $27.27 with a 10% is $24.54
        $27.27 with a 15% is $23.18
        $27.27 with a 20% is $21.82
        $27.27 with a 25% is $20.45
        $27.27 with a 30% is $19.09
        ----------------------------------------------------
      *************************************************************************/
    }

    public static decimal EuroConverter(decimal x)
    {
        //convert the euros to USD
      decimal conversion = 1.16m * x;

        //return the value of conversion
      return conversion;
    }

    public static decimal MassConverter(int weight, decimal percentage)
    {
        /*
         * calculate the weight in the planet if choice using the % and
         * weight on earth
         */
      decimal weightInPlanet = weight * percentage;

        //return the weight in the planet of choice
      return weightInPlanet;
    }

    public static decimal DiscountCalc(decimal price, decimal discount)
    {
        //calculate the price of discount
      decimal discountPrice = price * (discount / 100);

        //calculate the new price after discount
      decimal newPrice = price - discountPrice;

        //return the new price
      return newPrice;
    }
  }
}
