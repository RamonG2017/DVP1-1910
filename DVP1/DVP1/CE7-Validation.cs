using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ReadAllLines used to print out text file of ASCII art

// Name: Ramón González Argüello
// Date: October 2019   
// CE Name: Coding Exercise 7 - Validation

/*
 * Synopsis: This class simply makes validation easier and less repetitive
 */

namespace DVP1
{
  class CE7_Validation
  {
    public static string StringValidation(string s)
    {
      Console.WriteLine(s);

      string response = Console.ReadLine();

      //check for null or whitespace input
      while (string.IsNullOrWhiteSpace(response))
      {
        Console.WriteLine("\r\nPlease do not leave this blank!");

        //store the user name
        response = Console.ReadLine();
      }

      return response;
    }

    public static int IntegerValidation(string s)
    {
      Console.WriteLine(s);

      string response = Console.ReadLine();

      int validation = 0;

      while (!(int.TryParse(response, out validation)) || validation < 0)
      {
        Console.WriteLine("\r\nPlease only enter a positive whole numbers");

        //store the inputed age from the user
        response = Console.ReadLine();
      }

      return validation;
    }

    public static int IntegerValidationWithRange(string s, int x, int y)
    {
      Console.WriteLine(s);

      string response = Console.ReadLine();

      int validation = 0;

      while (!(int.TryParse(response, out validation)) || validation < x
             || validation > y)
      {
        Console.WriteLine("\r\nPlease only enter a positive whole numbers" +
                          " and within the displayed choices");

        //store the inputed age from the user
        response = Console.ReadLine();
      }

      return validation;
    }

    public static string NumberOfWordsValidation(string s)
    {
      Console.WriteLine(s);

      string response = Console.ReadLine();

      //check for null or whitespace input plus range is at least 6 words
      while (string.IsNullOrWhiteSpace(response) ||
             response.Split(' ', '.', ',', '!', '?').Length <= 6)
      {
        Console.WriteLine("\r\nPlease do not leave this blank! And please" +
                          "make sure the number has at least 6 " +
                          "words");

        Console.WriteLine("To begin, please enter a sentence containing at " +
                        "least 6 words...");

        //store the user sentence
        response = Console.ReadLine();
      }

      return response;
    }
  }
}

