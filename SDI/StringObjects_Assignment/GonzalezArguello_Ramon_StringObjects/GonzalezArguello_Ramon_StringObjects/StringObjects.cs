/******************************************************************************
filename   StringObjects.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 09        
due date   29/08/2019

 Brief Description:
 Program that solves 2 problems using String objects and String methods.
******************************************************************************/

using System;

namespace GonzalezArguello_Ramon_StringObjects
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      /*************************************************************************
         Problem #1: Credit Card Obscurer

         Description:
           	Prompts  the user for a credit card number and obscuring all of
            the numbers except the last 4.
       ************************************************************************/

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #1: Credit Card Obscurer");
      Console.WriteLine("\r\n");

      Console.WriteLine("Please enter your credit card number:");

        //store the card number
      string numberString = Console.ReadLine();

        //check for null or whitespace input plus range between 12-16 chars
      while (string.IsNullOrWhiteSpace(numberString) ||
             (numberString.Length < 12 || numberString.Length > 16))
      {
        Console.WriteLine("\r\nPlease do not leave this blank! And please" +
                          "make sure the number has between 12 and 16 " +
                          "characters");

        Console.WriteLine("Please enter your credit card number:");

          //store the card number
        numberString = Console.ReadLine();
      }

      string encryptedNumber = CardNumberEncryption(numberString);

      Console.WriteLine("You can now check out with your credit card ending " +
                        "in " + encryptedNumber);

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
       Test #1 results:
        ----------------------------------------------------
        Problem #1: Credit Card Obscurer


        Please enter your credit card number:
        124569424567
        You can now check out with your credit card ending in XXXXXXXX4567
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #1: Credit Card Obscurer


        Please enter your credit card number:
        9876543278564567
        You can now check out with your credit card ending in XXXXXXXXXXXX4567
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #1: Credit Card Obscurer


        Please enter your credit card number:
        123456789

        Please do not leave this blank! And pleasemake sure the number has
        between 12 and 16 characters
        Please enter your credit card number:
        12345678912

        Please do not leave this blank! And pleasemake sure the number has
        between 12 and 16 characters
        Please enter your credit card number:
        123456789123456
        You can now check out with your credit card ending in XXXXXXXXXXX3456
        ----------------------------------------------------
      *************************************************************************/

      /*************************************************************************
         Problem #2: THE search

         Description:
           	searches through a text string from the user and count the number of
            times the word “the” is in the whole string.
      ************************************************************************/

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("Problem #2: THE search");
      Console.WriteLine("\r\n");

      Console.WriteLine("Please enter a sentence:");

        //store the sentece inputed by the user
      string sentence = Console.ReadLine();

      while (string.IsNullOrWhiteSpace(sentence))
      {
        Console.WriteLine("\r\nPlease do not leave this blank!");

        Console.WriteLine("Please enter a sentence:");

          //store the sentece inputed by the user
        sentence = Console.ReadLine();
      }

        /*
         * make a string array by separating the original string with the
         * .Split funcition
         */
      string[] sentenceArray = sentence.Split(' ');

        //store the returned value from the called function
      int count = TheCount(sentenceArray);

      Console.WriteLine("Your sentence contains " + sentenceArray.Length +
                        " word(s) and the word THE appears " + count +
                        " times");

      Console.WriteLine("----------------------------------------------------");
      Console.WriteLine("\r\n");

      /*************************************************************************
       Test #2 results:
        ----------------------------------------------------
        Problem #2: THE search


        Please enter a sentence:
        This is a test string to see if the program is working.
        Your sentence contains 12 word(s) and the word THE appears 1 times
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #2: THE search


        Please enter a sentence:
        The best movie that the Redbox machine currently has in stock is
        The Wold of Wall Street.
        Your sentence contains 17 word(s) and the word THE appears 3 times
        ----------------------------------------------------

        ----------------------------------------------------
        Problem #2: THE search


        Please enter a sentence:
        The is one of the most common words used in the English language.
        In this problem, we will search through a text string from the user
        and count the number of times the word the is in the whole string
        Your sentence contains 40 word(s) and the word THE appears 8 times
        ----------------------------------------------------
      *************************************************************************/
    }

    public static string CardNumberEncryption(string creditCardNumber)
    {
        //create a character array that stores every digit of the argument
      char[] numberArray = creditCardNumber.ToCharArray();

      for (int i = 0; i < (numberArray.Length - 4); i++)
      {
          //replace all but the last 4 digits as X
        numberArray[i] = 'X';
      }

        //store the new blacked out number as a string to return
      string numberEncryptedString = new string(numberArray);

        //return the blacked out number
      return numberEncryptedString;
    }

    public static int TheCount(string[] sentence)
    {
        /*
         * variable that store the amount of time the word "the" appears
         * in the sentence
         */
      int timesWordAppears = 0;

      for (int i = 0; i < sentence.Length; i++)
      {
        if (sentence[i] == "The" || sentence[i] == "THE" ||
            sentence[i] == "the")
        {
            //increase the count by 1 each time "the" appears
          timesWordAppears += 1;
        }
      }

        //return the amount of times the word "the" appears
      return timesWordAppears;
    }
  }
}
