using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ReadAllLines used to print out text file of ASCII art

// Name: Ramón González Argüello
// Date: October 2019   
// CE Name: Coding Exercise 1 - Menu

/*
 * Synopsis: This class welcomes the user to the menu of the coding exercises
 * and grants access to the coding exercises and whenever 0 is pressed then
 * the program ends
 */

namespace DVP1
{
  class CE1_Menu
  {
    public static void DisplayMenu()
    {
      string option = "0";

      //clear the console so that the menu is the only thing displayed
      Console.Clear();

      do
      {
        /*
         * define the path of the text file that is going to be accessed
         * 
         * NOTE: the file path must be changed to whatever the path is of the
         * file in each individual computer.
         */
        string filePath = @"/Users/ramongonzalezarguello/Documents/GitHub/" +
                          @"dvp1-1910-RamonG2017/HeaderTextFiles/" +
                          @"MenuHeader.txt";

        //create a string list that stores every individual line of the txt file
        List<string> fileLines = File.ReadAllLines(filePath).ToList();

        //print each line of the string list
        foreach (string line in fileLines)
        {
          Console.WriteLine(line);
        }


        Console.WriteLine("\r\n");

        Console.WriteLine("Coding Challenge Menu:");
        Console.WriteLine("Please enter the number for the challenge " +
                          "you want to run...");

        Console.WriteLine("\r\n");

        Console.WriteLine("\t[1] Swap Name");
        Console.WriteLine("\t[2] Backwards");
        Console.WriteLine("\t[3] Age Convert");
        Console.WriteLine("\t[4] Temp Convert");
        Console.WriteLine("\t[5] Big Blue Fish");

        Console.Write("\r\n");

        Console.WriteLine("\t[0] Exit");

        Console.Write("\r\n");

        Console.WriteLine("=============================================" +
                          "=========================");

        Console.Write("Make your selection: ");

        //read whatever the user inputs and uses it to access the options given
        option = Console.ReadLine();

        switch (option)
        {
          case "1":
            CE2_SwapNames.SwapNameStart();
            Console.ReadKey();
            break;
          case "2":
            CE3_Backwards.BackwardsStart();
            Console.ReadKey();
            break;
          case "3":
            CE4_AgeConvert.AgeConvertStart();
            Console.ReadKey();
            break;
          case "4":
            CE5_TempConvert.TempConvertStart();
            Console.ReadKey();
            break;
          case "5":
            CE6_BigBlueFish.BigBlueFishStart();
            Console.ReadKey();
            break;
          case "0":
            Console.Clear();
            Console.WriteLine("Goodbye...");
            Console.ReadKey();
            break;
          default:
            Console.Clear();
            Console.WriteLine("Please enter a valid option!");
            Console.ReadKey();
            break;
        }
      } while (option != "0");
    }
  }
}
