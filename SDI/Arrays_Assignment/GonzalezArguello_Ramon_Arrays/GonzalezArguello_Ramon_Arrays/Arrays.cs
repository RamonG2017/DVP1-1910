/******************************************************************************
filename   Arrays.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 05        
due date   28/08/2019

 Brief Description
 Utilizes arrays to do a variety of things and print out the results to the
 console.
******************************************************************************/

using System;

namespace GonzalezArguello_Ramon_Arrays
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      /*************************************************************************
         Problem #1: Book Buyer

         Description:
           	prompting	the	user	for	the	number	of	books	the	user	wants	to
            buy	at	a	store. Then	it	will	ask	for	the	price	of	each	book
            and	then	present	the	user	with	the	total.
       ************************************************************************/

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #1: Book Buyer");
      Console.WriteLine("\r\n");

        //store the total cost of the books
      decimal totalBookCost = 0;

      Console.WriteLine("You will be asked for how many books you would like" +
                        " to purchase and the cost of each book. You will" +
                        " then be showed the total cost of your purchase.\r\n");

      Console.WriteLine("How many books would you like to buy?");

        //store the amount of books being purchased by the user
      string bookAmountString = Console.ReadLine();

        //variable used to store the book amount and validate it as an int
      int bookAmount = 0;

        //conitional loop to test if the user input is an int
      while (!(int.TryParse(bookAmountString, out bookAmount))
             || bookAmount <= 0)
      {
        Console.WriteLine("\r\nPlease enter a number and make it greater " +
                  "than zero");


        Console.WriteLine("How many books would you like to buy?");

          //store the amount of books being purchased by the user
        bookAmountString = Console.ReadLine();
      }

        /*
         * array used to store the prices of the books with length determined
         * by the user input
         */
      decimal[] bookArray = new decimal[bookAmount];

        /*
         * loop that asks the user for the price of each book, stores it in
         * the previously created array and then calculates the total for
         * all books
         */
      for (int i = 1; i <= bookArray.Length; i++)
      {
        Console.WriteLine("How much does the " + i + " book cost?");

          //store the cost of the book given by the user
        string bookCostString = Console.ReadLine();

          //variable used to store the book cost and validate it as a decimal
        decimal bookCost = 0;

          //conitional loop to test if the user input is a decimal
        while (!(decimal.TryParse(bookCostString, out bookCost)))
        {
          Console.WriteLine("\r\nPlease enter a number");

          Console.WriteLine("How much does the " + i + " book cost?");

            //store the cost of the book given by the user
          bookCostString = Console.ReadLine();
        }

          /*
           * store the cost of the book in the array index of i-1 since
           * the loop starts at i = 1
           */
        bookArray[i - 1] = bookCost;

          //calculate and store the total price of the books being purchased
        totalBookCost = totalBookCost + bookArray[i - 1];
      }

      Console.WriteLine("Your total for " + bookAmount + " books is $" +
                        totalBookCost + ".");

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
      Test #1 results:
      ----------------------------------------------------
      Problem #1: Book Buyer


      You will be asked for how many books you would like to purchase and the
      cost of each book. You will then be showed the total cost of your
      purchase.

      How many books would you like to buy?
      3
      How much does the 1 book cost?
      5.50
      How much does the 2 book cost?
      10.25
      How much does the 3 book cost?
      Seventeen Dollars

      Please enter a number
      How much does the 3 book cost?
      17.00
      Your total for 3 books is $32.75.
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #1: Book Buyer


      You will be asked for how many books you would like to purchase and the
      cost of each book. You will then be showed the total cost of your
      purchase.

      How many books would you like to buy?
      4 
      How much does the 1 book cost?
      9.99 
      How much does the 2 book cost?
      24.34
      How much does the 3 book cost?
      12
      How much does the 4 book cost?
      25
      Your total for 4 books is $71.33.
      ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
         Problem #2: Coloring Outside The Lines

         Description:
           	Uses a loop to combine 2 string arrays together
       ************************************************************************/

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #2: Coloring Outside The Lines");
      Console.WriteLine("\r\n");

      string[] randomString = { "ball", "carrot", "towel", "laptop", "stove" };

      string[] colours = { "red", "orange", "white", "silver", "black" };

      for (int i = 0; i < randomString.Length; i++)
      {
        Console.WriteLine("The main colour of " + randomString[i] +
                            " is " + colours[i]);
      }

      Console.WriteLine("----------------------------------------------------");

      /*************************************************************************
      Test #2 results:
      ----------------------------------------------------
      Problem #2: Coloring Outside The Lines


      The main colour of grapes is purple
      The main colour of apples is red
      The main colour of limes is green
      The main colour of lemons is yellow
      ----------------------------------------------------

      ----------------------------------------------------
      Problem #2: Coloring Outside The Lines


      The main colour of ball is red
      The main colour of carrot is orange
      The main colour of towel is white
      The main colour of laptop is silver
      The main colour of stove is black
      ----------------------------------------------------
      
      *************************************************************************/
    }
  }
}
