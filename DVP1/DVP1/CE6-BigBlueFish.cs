using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ReadAllLines used to print out text file of ASCII art

// Name: Ramon Gonzalez Arguello
// Date: October 2019   
// CE Name: Coding Exercise 6 - Big Blue Fish

/*
 * Synopsis: Created 2 different arrays, one with the four different colours of
 * fish and another one with the respective size of each individual fish. The
 * user is asked what colour of fish they would like to use and the appropriate
 * method is called for that.
 */

namespace DVP1
{
  public class CE6_BigBlueFish
  {
    public static void BigBlueFishStart()
    {
      /*
       * string array that contains 12 entries of 4 colours of fish (some are
       * repeated).
       */
      string[] colours = new string[12] {"red", "yellow", "green", "red",
                                        "blue", "red", "green", "red",
                                        "yellow", "green", "blue", "yellow"};

      /*
       * float array that contains 12 different sizes that match to every
       * colour of their same index, they are all random numbers.
       */
      float[] fishSize = new float[12] {25.0f, 40.7f, 32.7f, 13.7f, 12.9f,
                                        49.9f, 31.0f, 41.6f, 46.6f, 19.6f,
                                        30.2f, 27.0f};

      Console.Clear();

      /*
       * define the path of the text file that is going to be accessed
       * 
       * NOTE: the file path must be changed to whatever the path is of the
       * file in each individual computer.
       */
      string filePath = @"/Users/ramongonzalezarguello/Documents/GitHub/" +
                        @"dvp1-1910-RamonG2017/HeaderTextFiles/" +
                        @"BigBlueFishHeader.txt";

      //create a string list that stores every individual line of the txt file
      List<string> fileLines = File.ReadAllLines(filePath).ToList();

      //print each line of the string list
      foreach (string line in fileLines)
      {
        Console.WriteLine(line);
      }

      Console.WriteLine("\r\n");

      Console.WriteLine("Welcome to BigBlueFish:");

      Console.Write("Looking for the biggest fish matching a " +
                        "certain color?");

      Console.WriteLine("\r\n");

      Console.WriteLine("Please select a colour of fish...");

      Console.WriteLine("\r\n");

      Console.WriteLine("\t[1] Red");
      Console.WriteLine("\t[2] Blue");
      Console.WriteLine("\t[3] Yellow");
      Console.WriteLine("\t[4] Green");

      Console.Write("\r\n");

      /*
       * store the selection the user gave as an int
       * and validate it through the CE7 class
       */
      int selection = CE7_Validation.IntegerValidationWithRange("Selection: ",
                                                                1, 4);

      /*
       * based on the selection, call the private method of the corrsponding
       * colour.
       */
      switch (selection)
      {
        case 1:
          RedFish(colours, fishSize);
          break;
        case 2:
          BlueFish(colours, fishSize);
          break;
        case 3:
          YellowFish(colours, fishSize);
          break;
        case 4:
          GreenFish(colours, fishSize);
          break;
      }

      Console.Write("\r\n");

      Console.WriteLine("=============================================" +
                        "=========================");

      Console.Write("Press any key to return to the main menu: ");
    }

    private static void RedFish(string[] colours, float[] fishSize)
    { 
      float largestFish = -1000.0f;

      for (int i = 0; i < colours.Length; i++)
      {
        if (colours[i] == "Red" || colours[i] == "red")
        {
          if (fishSize[i] > largestFish)
          {
            /*
             * if the current index is larger than the current largest then make
             * the largest fish size equal to the current index.
             */
            largestFish = fishSize[i];
          }
        }
      }

      Console.WriteLine("\r\nWoa! Looks like the biggest red fish is " +
                        largestFish + " inches.");
    }

    private static void BlueFish(string[] colours, float[] fishSize)
    {
      float largestFish = -1000.0f;

      for (int i = 0; i < colours.Length; i++)
      {
        if (colours[i] == "Blue" || colours[i] == "blue")
        {
          if (fishSize[i] > largestFish)
          {
            /*
             * if the current index is larger than the current largest then make
             * the largest fish size equal to the current index.
             */
            largestFish = fishSize[i];
          }
        }
      }

      Console.WriteLine("\r\nWoa! Looks like the biggest blue fish is " +
                        largestFish + " inches.");
    }

    private static void YellowFish(string[] colours, float[] fishSize)
    {
      float largestFish = -1000.0f;

      for (int i = 0; i < colours.Length; i++)
      {
        if (colours[i] == "Yellow" || colours[i] == "yellow")
        {
          if (fishSize[i] > largestFish)
          {
            /*
             * if the current index is larger than the current largest then make
             * the largest fish size equal to the current index.
             */
            largestFish = fishSize[i];
          }
        }
      }

      Console.WriteLine("\r\nWoa! Looks like the biggest yellow fish is " +
                        largestFish + " inches.");
    }

    private static void GreenFish(string[] colours, float[] fishSize)
    {
      float largestFish = -1000.0f;

      for (int i = 0; i < colours.Length; i++)
      {
        if (colours[i] == "Green" || colours[i] == "green")
        {
          if (fishSize[i] > largestFish)
          {
            /*
             * if the current index is larger than the current largest then make
             * the largest fish size equal to the current index.
             */
            largestFish = fishSize[i];
          }
        }
      }

      Console.WriteLine("\r\nWoa! Looks like the biggest green fish is " +
                        largestFish + " inches.");
    }
  }
}
