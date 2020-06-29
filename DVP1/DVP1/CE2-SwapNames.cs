using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ReadAllLines used to print out text file of ASCII art

// Name: Ramon Gonzalez Arguello
// Date: October 2019   
// CE Name: Coding Exercise 2 - Swap Name

/*
 * Synopsis: Asks for the first name and last name of the user then switches
 * the last name with the first name and prints it, then when the process is
 * finished it goes back to the menu after the user presses any key.
 */

namespace DVP1
{
  public class CE2_SwapNames
  {
    public static void SwapNameStart()
    {
      string firstName; //variable that will store the first name of the user
      string lastName;  //variable that will store the last name of the user

      //list that will store the names entered by the user
      List<string> nameList = new List<string>();

      Console.Clear();

      /*
       * define the path of the text file that is going to be accessed
       * 
       * NOTE: the file path must be changed to whatever the path is of the
       * file in each individual computer.
       */
      string filePath = @"/Users/ramongonzalezarguello/Documents/GitHub/" +
                        @"dvp1-1910-RamonG2017/HeaderTextFiles/" +
                        @"SwapNameHeader.txt";

      //create a string list that stores every individual line of the txt file
      List<string> fileLines = File.ReadAllLines(filePath).ToList();

      //print each line of the string list
      foreach (string line in fileLines)
      {
        Console.WriteLine(line);
      }

      Console.WriteLine("\r\n");

      Console.WriteLine("Welcome to SwapName:");

      Console.WriteLine();

      //store the inputed first name of the user
      firstName = CE7_Validation.StringValidation(
                  "To begin, please enter your first name...");

      //insert the first name as the first item in the list
      nameList.Insert(0, firstName);

      Console.WriteLine("\r\n");

      //store the inputed last name of the user
      lastName = CE7_Validation.StringValidation("Thank you " + nameList[0] +
                        ", now I will need your last name...");


      //insert the last name at the next location in the list
      nameList.Add(lastName);

      Console.WriteLine("\r\n");

      Console.Write("Excellent! Your name (" + firstName + " " + lastName +
                        ") reversed would be ");

      //calls the private method NameSwap that carries out the swapping
      NameSwap(nameList);

      Console.Write("\r\n");

      Console.WriteLine("=============================================" +
                        "=========================");

      Console.Write("Press any key to return to the main menu: ");
    }

    private static void NameSwap(List<string> nameList)
    {
      //temporary variable that stores the first name of the user
      string temp = nameList[0];

      //make the last name of the user the first location of the list
      nameList[0] = nameList[1];

      //make the next location of the list the first name/the temp value
      nameList[1] = temp;

      Console.Write(nameList[0] + ", " + nameList[1]);

    }

  }
}
