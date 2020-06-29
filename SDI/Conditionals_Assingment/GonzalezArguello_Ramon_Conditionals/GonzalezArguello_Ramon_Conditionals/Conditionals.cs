/******************************************************************************
filename   Conditionals.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 03        
due date   12/08/2019

 Brief Description:
  Program that based on different problems outputs different values based on
  user inputed data, using conditionals the disired output is given for each
  problem.
******************************************************************************/

using System;

namespace GonzalezArguello_Ramon_Conditionals
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      /*************************************************************************
        Problem	#1:	Free	Shipping

        Description:
          Prompt the user for the number of items that they are buying.
          If the user has 5 or more it is free. If they have less than 4 items,
          let them know the total of the shipping they will have to pay.
          Shipping will be $1.25 per item.
      *************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #1: Free Shipping");
      Console.WriteLine("\r\n");

        //variable that stores the value of the shipping
      decimal costOfShipping = 1.25m; 

        //variable used to store the total cost of shipping
      decimal totalCostOfShipping = 0;

      Console.WriteLine("How many items are you going to purchase today?");

        //store the amount of items being purchased
      string items = Console.ReadLine();

        //parse the inputed value from a string to an int
      int parseItems = int.Parse(items);

        /*
         * condition to check if the amount of items surpasses or is equal to 5
         * to give free shipping to the costumer, else shows the total price
         * of shipping.
         */
      if (parseItems >= 5)
      {
        Console.WriteLine("Congratulations, you have bought " +
                          parseItems + " items, so you qualify for free " +
                          "shipping!");
      }
      else
      {
          //calculate the total cost of shipping and then assign the value
        totalCostOfShipping = costOfShipping * parseItems;

        Console.WriteLine("Your cost for shipping today for " +
                           parseItems + " items is $"  + totalCostOfShipping
                           + ".");
      }

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
       Test #1 results:
       ----------------------------------------------------
       Problem #1: Free Shipping


       How many items are you going to purchase today?
       2
       Your cost for shipping today for 2 items is $2.50.
       ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Free Shipping


      How many items are you going to purchase today?
      4
      Your cost for shipping today for 4 items is $5.00.
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Free Shipping


      How many items are you going to purchase today?
      5
      Congratulations, you have bought 5 items, so you qualify for free
      shipping!
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Free Shipping


      How many items are you going to purchase today?
      7
      Congratulations, you have bought 7 items, so you qualify for free
      shipping!
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Free Shipping


      How many items are you going to purchase today?
      72
      Congratulations, you have bought 72 items, so you qualify for free
      shipping!
      ----------------------------------------------------
      *************************************************************************/


      /*************************************************************************
       Problem #2:	Mall Employee Discount

       Description:
         Calculate the total cost of two items that a customer will purchase
         and calculate a discount based on if the customer works at the mall or
         not. 
      *************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #2: Mall Employee Discount");
      Console.WriteLine("\r\n");

        //store the value of the employee discount 10%
      decimal employeeDiscount = 0.10m;

        //store the value for the total purchase/grand total
      decimal totalPurchase = 0;

        //store the value of the purchase discount
      decimal purchaseDiscount = 0;

        //store the value of the total purchase before discount
      decimal totalPurchasePreDiscount = 0;

      Console.Write("What is the cost of the first item: ");

        //store the first inputed item price
      string itemPrice1 = Console.ReadLine();

      Console.WriteLine("\r\n");

      Console.Write("What is the cost of the second item: ");

        //store the second inputed item price
      string itemPrice2 = Console.ReadLine();

      Console.WriteLine("\r\n");

        //parse the inputed first price from a string to a decimal
      decimal parseItemPrice1 = decimal.Parse(itemPrice1);

        //parse the inputed second price from a string to a decimal
      decimal parseItemPrice2 = decimal.Parse(itemPrice2);

      Console.WriteLine("Are you a mall employee? (yes/no)");

        //store the inputed answer
      string answer = Console.ReadLine();

      Console.WriteLine("\r\n");

        //convert the answer to all upper case to facilitate conditionals
      answer = answer.ToUpper();

        /*
         * condition to check if the person is an employee at the mall to apply
         * a 10% discount to their purchase
         */
      if (answer == "YES")
      {
          //calculate the total before employee discount
        totalPurchasePreDiscount = parseItemPrice1 + parseItemPrice2;

          //calculate the price of discount
        purchaseDiscount = totalPurchasePreDiscount * employeeDiscount;

          //calculate the total price after discount/grand total
        totalPurchase = totalPurchasePreDiscount - purchaseDiscount;

        Console.WriteLine("Your total purchase is $" +
                          totalPurchasePreDiscount +", but with your 10% " +
                          "employee discount it is now $" +
                          decimal.Round(totalPurchase, 2) + ".");

      }
      else
      {
          //calculate the total price before any discount
        totalPurchasePreDiscount = parseItemPrice1 + parseItemPrice2;

          //calculate the grand total without a discount
        totalPurchase = totalPurchasePreDiscount;

        Console.WriteLine("Your purchase is $" + totalPurchase + ".");
      }

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
       Test #2 results:
      ----------------------------------------------------
      Problem #2: Mall Employee Discount


      What is the cost of the first item: 65.90


      What is the cost of the second item: 85.00


      Are you a mall employee? (yes/no)
      yes


      Your total purchase is $150.90, but with your 10% employee discount it is
      now $135.81.
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #2: Mall Employee Discount


      What is the cost of the first item: 19.99


      What is the cost of the second item: 40.20


      Are you a mall employee? (yes/no)
      no


      Your purchase is $60.19.
      ----------------------------------------------------


      ----------------------------------------------------
      Problem #2: Mall Employee Discount


      What is the cost of the first item: 72.95


      What is the cost of the second item: 105.78


      Are you a mall employee? (yes/no)
      yes


      Your total purchase is $178.73, but with your 10% employee discount it is
      now $160.86.
      ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
       Problem #3: Apple Pickers

       Description:
         Determines the cost of a basket of apples by its weight.
         Prompts the user for the weight of the basket of apples, validating
         and converting it to a correct data type.
      *************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #3: Apple Pickers");
      Console.WriteLine("\r\n");

        //store the total cost of apples
      decimal totalCostOfApples = 0;

      Console.WriteLine("How much does your  basket  weigh?");

        //store the inputed weight of apples
      string weightOfApples = Console.ReadLine();

      Console.WriteLine("\r\n");

        //parse the inputed weight of apples from a string to a decimal
      decimal parseWeightOfApples = decimal.Parse(weightOfApples);

      /*
       * Conditional based on the weight of apples, each set amount of weight
       * has a specific price point ranging from $1 to $0.50
       */
      if (parseWeightOfApples < 7)
      {
          //calculate the total price for the apples
        totalCostOfApples = 1 * parseWeightOfApples;

        Console.WriteLine("Your basket of apples of " + parseWeightOfApples +
                          "lbs. costs $" +
                          decimal.Round(totalCostOfApples, 2) + ".");
      }
      else if (parseWeightOfApples == 7 || parseWeightOfApples < 15.25m)
      {
          //calculate the total price for the apples
        totalCostOfApples = 0.90m * parseWeightOfApples;

        Console.WriteLine("Your basket of apples of " + parseWeightOfApples +
                         "lbs. costs $" +
                         decimal.Round(totalCostOfApples, 2) + ".");

      }
      else if (parseWeightOfApples == 15.25m || parseWeightOfApples < 40)
      {
          //calculate the total price for the apples
        totalCostOfApples = 0.80m * parseWeightOfApples;

        Console.WriteLine("Your basket of apples of " + parseWeightOfApples +
                         "lbs. costs $" +
                         decimal.Round(totalCostOfApples, 2) + ".");
      }
      else if (parseWeightOfApples == 40 || parseWeightOfApples < 70.5m)
      {
          //calculate the total price for the apples
        totalCostOfApples = 0.70m * parseWeightOfApples;

        Console.WriteLine("Your basket of apples of " + parseWeightOfApples +
                         "lbs. costs $" +
                         decimal.Round(totalCostOfApples, 2) + ".");
      }
      else if (parseWeightOfApples == 70.5m || parseWeightOfApples <= 100)
      {
        //calculate the total price for the apples
        totalCostOfApples = 0.60m * parseWeightOfApples;

        Console.WriteLine("Your basket of apples of " + parseWeightOfApples +
                         "lbs. costs $" +
                         decimal.Round(totalCostOfApples, 2) + ".");
      }
      else
      {
          //calculate the total price for the apples
        totalCostOfApples = 0.50m * parseWeightOfApples;

        Console.WriteLine("Your basket of apples of " + parseWeightOfApples +
                         "lbs. costs $" +
                         decimal.Round(totalCostOfApples, 2) + ".");
      }

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
       Test #3 results:
        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        4.5


        Your basket of apples of 4.5lbs. costs $4.5.
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        10


        Your basket of apples of 10lbs. costs $9.00.
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        15.25


        Your basket of apples of 15.25lbs. costs $12.20.
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        30


        Your basket of apples of 30lbs. costs $24.00.
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        60.50


        Your basket of apples of 60.50lbs. costs $42.35.
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        100


        Your basket of apples of 100lbs. costs $60.00.
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        150.30


        Your basket of apples of 150.30lbs. costs $75.15.
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #3: Apple Pickers


        How much does your  basket  weigh?
        17.947994 


        Your basket of apples of 17.947994lbs. costs $14.36.
        ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
       Problem #4: Nerd Out

       Description:
         Determines the cost of a ticket to comic-con based on the age of the
         user.
      *************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #4: Nerd Out");
      Console.WriteLine("\r\n");

      Console.WriteLine("How old are you?");

        //store the inputed age of the user
      string age = Console.ReadLine();

      Console.WriteLine("\r\n");

        //parse the inputed age from string to int
      int parseAge = int.Parse(age);

      /*
       * Conditional to check if the user's age fits between the criteria for a
       * lower priced ticket
       */
      if (parseAge < 7 || parseAge >= 65)
      {
        Console.WriteLine("Your cost for your ticket to Comic Con is $40.00");
      }
      else
      {
        Console.WriteLine("Your cost for your ticket to Comic Con is $55.00");
      }

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
       Test #3 results:
        ----------------------------------------------------
        Problem #4: Nerd Out


        How old are you?
        68


        Your cost for your ticket to Comic Con is $40.00
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #4: Nerd Out


        How old are you?
        29


        Your cost for your ticket to Comic Con is $55.00
        ----------------------------------------------------

      ----------------------------------------------------
      Problem #4: Nerd Out


      How old are you?
      6


      Your cost for your ticket to Comic Con is $40.00
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #4: Nerd Out


      How old are you?
      7


      Your cost for your ticket to Comic Con is $55.00
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #4: Nerd Out


      How old are you?
      109


      Your cost for your ticket to Comic Con is $40.00
      ----------------------------------------------------
      *************************************************************************/
    }
  }
}
