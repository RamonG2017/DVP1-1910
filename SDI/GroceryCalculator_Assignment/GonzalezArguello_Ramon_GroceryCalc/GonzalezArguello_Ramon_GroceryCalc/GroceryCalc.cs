/******************************************************************************
filename   GroceryCalc.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 02         
due date   08/08/2019

 Brief Description:
  Program that will add	up the cost of a specific number	of	items	and	then
  add	in	sales	tax to calculate the total bill.
******************************************************************************/

using System;

namespace GonzalezArguello_Ramon_GroceryCalc
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      decimal totalBeforeTax = 0; //variable that stores the total before tax

      decimal totalAfterTax = 0; // variable that stores the total after tax

        //variable that stores the total price for banana
      decimal totalPriceBanana = 0; 

       //variable that stores the total price for brisket
      decimal totalPriceBrisket = 0;

        //variable that stores the total price for apple pie
      decimal totalPricePie = 0;

        //variable that stores the sales tax in decimal
      decimal salesTaxDecimal = 0;

      decimal salesTaxTotal = 0;

      Console.WriteLine("What is the price of one banana?");
        //store the cost of a banana
      string bananaPrice = Console.ReadLine();


      Console.WriteLine("What is the price of one pound of beef brisket?");
        //store the cost of brisket
      string brisketPrice = Console.ReadLine();


      Console.WriteLine("What is the price of one apple pie?");
        //store the cost of beef brisket
      string piePrice = Console.ReadLine();

        //parse the value entered for bananas from string to decimal
      decimal parseBananaPrice = decimal.Parse(bananaPrice);

        //parse the value entered for brisket from string to decimal
      decimal parseBrisketPrice = decimal.Parse(brisketPrice);

        //parse the value entered for apple pie from string to decimal
      decimal parsePiePrice = decimal.Parse(piePrice);

      Console.WriteLine("How many bananas would you like to buy?");

        //store the amount of bananas being bought
      string bananaQuantity = Console.ReadLine();

      Console.WriteLine("How many pounds of brisket would you like to buy?");

        //store the amount of brisket being bought
      string brisketQuantity = Console.ReadLine();

      Console.WriteLine("How many apple pies would you like to buy?");

        //store the amount of apple pies being bought
      string pieQuantity = Console.ReadLine();

        //parse the amount of bananas from string to int
      int parseBananaQuantity = int.Parse(bananaQuantity);

        //parse the amount of brisket from string to int
      int parseBrisketQuantity = int.Parse(brisketQuantity);

        //parse the amount of apple pies from string to int
      int parsePieQuantity = int.Parse(pieQuantity);

      Console.WriteLine("What is the sales tax where you live (percentage)?");

        //store the percentage sales tax
      string salesTax = Console.ReadLine();

        //parse the sales tax from string to decimal
      decimal parseSalesTax = decimal.Parse(salesTax);

        //calculate the total price of bananas
      totalPriceBanana = parseBananaQuantity * parseBananaPrice;
     
        //calculate the total price of brisket
      totalPriceBrisket = parseBrisketQuantity * parseBrisketPrice;
 
        //calculate the total price of pies
      totalPricePie = parsePieQuantity * parsePiePrice;

        //calculate the total price of before tax
      totalBeforeTax = totalPriceBanana + totalPriceBrisket + totalPricePie;

        //convert the sales tax from a % to a decimal
      salesTaxDecimal = parseSalesTax / 100;

        //calculate the price of sales tax
      salesTaxTotal = (totalBeforeTax * salesTaxDecimal);
 
        //calculate the grand total
      totalAfterTax = (totalBeforeTax * salesTaxDecimal) + totalBeforeTax;
      

      Console.WriteLine("The cost of " + parseBananaQuantity + " bananas is " +
                        "$" + totalPriceBanana + ".");

      Console.WriteLine("The cost of " + parseBrisketQuantity + " pounds of " +
                        "brisket is " + "$" + totalPriceBrisket + ".");

      Console.WriteLine("The cost of " + parsePieQuantity + " apple pies is " +
                        "$" + totalPricePie + ".");

      Console.WriteLine("Your total before tax is: " + "$"  + totalBeforeTax +
                        ".");

      Console.WriteLine("Your total sales tax is: " + "$" + salesTaxTotal +
                        ".");

      Console.WriteLine("Your grand total is: " + "$" + totalAfterTax +  ".");
    }
  }
}

/******************************************************************************
  Test #1 results:
  What is the price of one banana?
  0.40
  What is the price of one pound of beef brisket?
  20.25
  What is the price of one apple pie?
  9.75
  How many bananas would you like to buy?
  4
  How many pounds of brisket would you like to buy?
  2
  How many apple pies would you like to buy?
  3
  What is the sales tax where you live (percentage)?
  5
  The cost of 4 bananas is $1.60.
  The cost of 2 pounds of brisket is $40.50.
  The cost of 3 apple pies is $29.25.
  Your total before tax is: $71.35.
  Your total sales tax is: $3.5675.
  Your grand total is: $74.9175.
******************************************************************************/

/******************************************************************************
  Test #2 results:
  What is the price of one banana?
  0.75
  What is the price of one pound of beef brisket?
  13.24
  What is the price of one apple pie?
  3.75
  How many bananas would you like to buy?
  6
  How many pounds of brisket would you like to buy?
  4
  How many apple pies would you like to buy?
  2
  What is the sales tax where you live (percentage)?
  9
  The cost of 6 bananas is $4.50.
  The cost of 4 pounds of brisket is $52.96.
  The cost of 2 apple pies is $7.50.
  Your total before tax is: $64.96.
  Your total sales tax is: $5.8464.
  Your grand total is: $70.8064.
******************************************************************************/
