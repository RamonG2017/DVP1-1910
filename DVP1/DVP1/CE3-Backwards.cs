using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ReadAllLines used to print out text file of ASCII art

// Name: Ramon Gonzalez Arguello
// Date: October 2019   
// CE Name: Coding Exercise 3 - Backwards

/*
 * Synopsis: Asks for a minimum 6 word sentece from the user, displays that
 * sentence then completely reverses the sentence and displays that reversed
 * sentence in the end.
 */

namespace DVP1
{
  public class CE3_Backwards
  {
    public static void BackwardsStart()
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
                        @"BackwardsHeader.txt";

      //create a string list that stores every individual line of the txt file
      List<string> fileLines = File.ReadAllLines(filePath).ToList();

      //print each line of the string list
      foreach (string line in fileLines)
      {
        Console.WriteLine(line);
      }

      Console.WriteLine("\r\n");

      Console.WriteLine("Welcome to Backwards:");

      //store inputed user sentence as a string from whatever is inputed
      string userSentence = CE7_Validation.NumberOfWordsValidation(
                           "To begin, please enter a sentence containing at " +
                           "least 6 words...");

      Console.WriteLine("\r\n");

      Console.WriteLine("Thank you, you entered the sentence:");
      Console.WriteLine(userSentence);

      //store the return value from the reverseUserSentence method as a string
      string reverseSentence = reverseUserSentence(userSentence);

      Console.WriteLine("\r\n");

      Console.WriteLine("Backwards this sentence would read: ");

      Console.WriteLine(reverseSentence);

      Console.Write("\r\n");

      Console.WriteLine("=============================================" +
                        "=========================");

      Console.Write("Press any key to return to the main menu: ");
    }

    private static string reverseUserSentence(string userSentence)
    {
      //create a blank variable where the reverse string will be stored
      string reverseString = "";

      //create a blank int variable to store the length of the string
      int length;

      //create a string variable with the assigned value of the method parameter
      string stringInput = userSentence;

        //make length equal to the length of the user sentence minus one
      length = stringInput.Length - 1;

      while (length >= 0)
      {
        //concat the reverse string variable with the string input current index
        reverseString = reverseString + stringInput[length];

        //make length smaller by 1
        length--;
      }

      //return the reverse string variable
      return reverseString;
    }
  }
}
