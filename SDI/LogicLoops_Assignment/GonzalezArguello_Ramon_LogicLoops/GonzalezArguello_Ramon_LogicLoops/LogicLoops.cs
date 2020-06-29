/******************************************************************************
filename   LogicLoops.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 04        
due date   27/08/2019

 Brief Description:
  Program that based on different problems outputs different values based on
  user inputed data, using loops the disired output is given for each
  problem.
******************************************************************************/

using System;

namespace GonzalezArguello_Ramon_LogicLoops
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      /*************************************************************************
        Problem	#1:	Piggy Bank

        Description:
          asks the user how much money is in their piggy bank to start with.
          Then asks them for an amount they will add each month. Then tells
          them the total they will have after 1 year.
      *************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #1: Piggy Bank");
      Console.WriteLine("\r\n");

        //variable used to store the total stored in the piggy bank per month
      decimal totalPerMonth = 0;

      Console.WriteLine("How much money do you have in your piggy bank?");

        //store the amount starting money
      string startingMoneyString = Console.ReadLine();

        //variable used to catch converted value
      decimal startingMoney = 0;

        //conitional loop to test if the user input is a decimal
      while (!(decimal.TryParse(startingMoneyString, out startingMoney)))
      {
        Console.WriteLine("\r\nPlease enter a number");
        
        Console.WriteLine("How much money do you have in your piggy bank?");

          //store the amount starting money
        startingMoneyString = Console.ReadLine();
      }

      Console.WriteLine("How much money would you add to the piggy bank each " 
                        + "month?");

        //store the amount of money added per month
      string addedMoneyString = Console.ReadLine();

        //variable used to catch converted value
      decimal addedMoney = 0;

        //conitional loop to test if the user input is a decimal
      while (!(decimal.TryParse(addedMoneyString, out addedMoney)))
      {
        Console.WriteLine("\r\nPlease enter a number");

        Console.WriteLine("How much money would you add to the piggy bank each "
                        + "month?");

         //store the amount of items being purchased
        addedMoneyString = Console.ReadLine();

      }

        //calculate the total per month
      totalPerMonth = startingMoney + addedMoney;

      Console.WriteLine("\r\n");

      Console.WriteLine("This month you now have $" + totalPerMonth +
                          " in your piggy bank!");


      for (int i = 0; i < 11; i++)
      {
          //add the monthly money
        totalPerMonth += addedMoney;

        Console.WriteLine("This month you now have $" + totalPerMonth +
                          " in your piggy bank!");
      }

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
      Test #1 results:
      ----------------------------------------------------
      Problem #1: Piggy Bank


      How much money do you have in your piggy bank?
      ten

      Please enter a number
      How much money do you have in your piggy bank?
      10.00
      How much money would you add to the piggy bank each month?
      5.50


      This month you now have $15.50 in your piggy bank!
      This month you now have $21.00 in your piggy bank!
      This month you now have $26.50 in your piggy bank!
      This month you now have $32.00 in your piggy bank!
      This month you now have $37.50 in your piggy bank!
      This month you now have $43.00 in your piggy bank!
      This month you now have $48.50 in your piggy bank!
      This month you now have $54.00 in your piggy bank!
      This month you now have $59.50 in your piggy bank!
      This month you now have $65.00 in your piggy bank!
      This month you now have $70.50 in your piggy bank!
      This month you now have $76.00 in your piggy bank!
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Piggy Bank


      How much money do you have in your piggy bank?
      one hundred and seven

      Please enter a number
      How much money do you have in your piggy bank?
      107.00
      How much money would you add to the piggy bank each month?
      20.00


      This month you now have $127.00 in your piggy bank!
      This month you now have $147.00 in your piggy bank!
      This month you now have $167.00 in your piggy bank!
      This month you now have $187.00 in your piggy bank!
      This month you now have $207.00 in your piggy bank!
      This month you now have $227.00 in your piggy bank!
      This month you now have $247.00 in your piggy bank!
      This month you now have $267.00 in your piggy bank!
      This month you now have $287.00 in your piggy bank!
      This month you now have $307.00 in your piggy bank!
      This month you now have $327.00 in your piggy bank!
      This month you now have $347.00 in your piggy bank!
      ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
       Problem #2: 3, 2, 1, Blast Off!

       Description:
         Countdown	clock	for	a	rocket	launch.
      *************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #2: 3, 2, 1, Blast Off!");
      Console.WriteLine("\r\n");

      Console.WriteLine("Hello and welcome to the rocket launch countdown" +
                        " program where YOU get to decide how long the " +
                        "countdown is!");

      Console.WriteLine("\r\nHow long would you like the countdown to be?");

      //store the inputed countdown
      string countdownString = Console.ReadLine();

      //variable used to catch converted value
      int countdown;

      //conitional loop to test if the user input is an int
      while (!(int.TryParse(countdownString, out countdown)))
      {
        Console.WriteLine("\r\nPlease enter a number");

        Console.WriteLine("How long would you like the countdown to be?");

        //store the amount starting money
        countdownString = Console.ReadLine();
      }

      for (int i = countdown - 1; i >= 0; i--)
      {
          //substract 1 from countdown
        countdown = countdown - 1;

        Console.WriteLine(countdown);
      }

      Console.WriteLine("Blast Off!");

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
      Test #2 results:
      ----------------------------------------------------
      Problem #2: 3, 2, 1, Blast Off!


      Hello and welcome to the rocket launch countdown program where YOU get to
      decide how long the countdown is!

      How long would you like the countdown to be?
      5
      4
      3
      2
      1
      0
      Blast Off!
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #2: 3, 2, 1, Blast Off!


      Hello and welcome to the rocket launch countdown program where YOU get to
      decide how long the countdown is!

      How long would you like the countdown to be?
      seven

      Please enter a number
      How long would you like the countdown to be?
      7
      6
      5
      4
      3
      2
      1
      0
      Blast Off!
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #2: 3, 2, 1, Blast Off!


      Hello and welcome to the rocket launch countdown program where YOU get to
      decide how long the countdown is!

      How long would you like the countdown to be?
      twelve

      Please enter a number
      How long would you like the countdown to be?
      12
      11
      10
      9
      8
      7
      6
      5
      4
      3
      2
      1
      0
      Blast Off!
      ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
       Problem #3: Darn Good Donuts

       Description:
         There is a box of donuts in the break room where the user works. The
         user will take this box and offer his co-workers donuts out of the box
         until he runs out.
      *************************************************************************/
      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #3: Darn Good Donuts");
      Console.WriteLine("\r\n");

      Console.WriteLine("How many donuts are there in the box?");

        //store the amount of donuts the box is holding 
      string boxAmountString = Console.ReadLine();

        //store the amount of donuts the bos is holding as an integer
      int boxAmount = 0;

      //conitional loop to test if the user input is an int
      while (!(int.TryParse(boxAmountString, out boxAmount)) || boxAmount <= 0)
      {
        Console.WriteLine("\r\nPlease enter a number and make it greater " +
                          "than zero");

        Console.WriteLine("How many donuts are there in the box?");

        //store the amount of donuts the box is holding
        boxAmountString = Console.ReadLine();
      }

      //loop that checks whether the box is still full or not 
      while (boxAmount > 0)
      {
        Console.WriteLine("How many donuts would you like?");

          //store the amount of donuts asked for
        string donutAmountString = Console.ReadLine();

          //store the amount of donuts asked for as an int
        int donutAmount = 0;

        while (!(int.TryParse(donutAmountString, out donutAmount)) ||
               (donutAmount > 3 || donutAmount < 0))
        {
          Console.WriteLine("\r\nPlease enter a number and make it between " +
                            "zero and three.");

          Console.WriteLine("How many donuts would you like?");

          //store the amount of donuts asked for
          donutAmountString = Console.ReadLine();
        }

          //take away the donuts from the amount in the box
        boxAmount = boxAmount - donutAmount;

          //break if the box amount is negative to display the negative prompt
        if (boxAmount < 0)
        {
          break;
        }

        Console.WriteLine("There are " + boxAmount + " donut(s) left in	" +
                          "the box");

          //check that if after taking away donuts it reaches zero to break
        if (boxAmount == 0)
        {
          Console.WriteLine("Donuts are all gone, hope everyone enjoys them!");
          break;
        }

      }

        //check if any donuts are owed 
      if (boxAmount < 0)
      {
          //make the box amount a positive number for display purposes
        boxAmount = boxAmount * -1;

        Console.WriteLine("I ran out of donut(s), I will have to owe you " +
                          + boxAmount + " donuts tomorrow.");
      }

      Console.WriteLine("----------------------------------------------------");

      /*************************************************************************
      Test #2 results:
      ----------------------------------------------------
      Problem #3: Darn Good Donuts


      How many donuts are there in the box?
      12
      How many donuts would you like?
      2
      There are 10 donut(s) left in	the box
      How many donuts would you like?
      0
      There are 10 donut(s) left in	the box
      How many donuts would you like?
      three

      Please enter a number and make it between zero and three.
      How many donuts would you like?
      3
      There are 7 donut(s) left in	the box
      How many donuts would you like?
      5

      Please enter a number and make it between zero and three.
      How many donuts would you like?
      3
      There are 4 donut(s) left in	the box
      How many donuts would you like?
      2
      There are 2 donut(s) left in	the box
      How many donuts would you like?
      2
      There are 0 donut(s) left in	the box
      Donuts are all gone, hope everyone enjoys them!
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #3: Darn Good Donuts


      How many donuts are there in the box?
      4
      How many donuts would you like?
      3
      There are 1 donut(s) left in	the box
      How many donuts would you like?
      0
      There are 1 donut(s) left in	the box
      How many donuts would you like?
      2
      I ran out of donut(s), I will have to owe you 1 donuts tomorrow.
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #3: Darn Good Donuts


      How many donuts are there in the box?
      3
      How many donuts would you like?
      2
      There are 1 donut(s) left in	the box
      How many donuts would you like?
      0
      There are 1 donut(s) left in	the box
      How many donuts would you like?
      0
      There are 1 donut(s) left in	the box
      How many donuts would you like?
      6

      Please enter a number and make it between zero and three.
      How many donuts would you like?
      -1

      Please enter a number and make it between zero and three.
      How many donuts would you like?
      1
      There are 0 donut(s) left in	the box
      Donuts are all gone, hope everyone enjoys them!
      ----------------------------------------------------
      *************************************************************************/

    }
  }
}
