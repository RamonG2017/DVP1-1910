/******************************************************************************
filename   MadLibs.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 01         
due date   07/08/2019

 Brief Description:
  This program prompts a user for various words and numbers that are going to
  be used to fill up a MadLib story. This program will convert the numbers
  from a string to a suitable data type and then using concatenated text and
  output the story.

******************************************************************************/
using System;

namespace GonzalezArguello_Ramon_MadLibs
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to my MadLib program there will be a series" +
                        " of prompts after this statement and at the end what" +
                        " you typed will be used to create a finished story.");

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter the name of an animal: ");

        //store the inputed value for the first animal
      string animalOne = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a name of a person (male): ");

       //store the inputed value for the first name
      string nameOne = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter an adjective: ");

        //store the inputed value for the first adjective
      string adjectiveOne = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter the name of a food item: ");

        //store the inputed value for the first food item
      string foodItemOne = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a name of a person: ");

        //store the inputed value for the second name
      string nameTwo = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter an adjective: ");

        //store the inputed value for the second adjective
      string adjectiveTwo = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a year: ");

        //store the inputed value for the year
      string year = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter an adjective: ");

        //store the inputed value for the third adjective
      string adjectiveThree = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter the name of a food item: ");

        //store the inputed value for the second food item
      string foodItemTwo = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a cost: ");

        //store the inputed value for the cost
      string cost = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a random number: ");

        //store the inputed value for the random number
      string number = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a noun: ");

        //store the inputed value for the first noun
      string nounOne = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a sound: ");

        //store the inputed value for the sound
      string sound = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a facial expression: ");

        //store the inputed value for the facial expression
      string expression = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a verb: ");

        //store the inputed value for the first verb
      string verbOne = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a noun: ");

        //store the inputed value for the second noun
      string nounTwo = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter an adjective: ");

        //store the inputed value for the fourth adjective
      string adjectiveFour = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a verb: ");

        //store the inputed value for the second verb
      string verbTwo = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter a vehicle: ");

        //store the inputed value for the vehicle
      string vehicle = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter an article of clothing: ");

        //store the inputed value for the article of clothing
      string clothes = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.Write("Please enter the name of an animal: ");

        //store the inputed value for the second animal
      string animalTwo = Console.ReadLine();

      Console.WriteLine("\r\n"); //create a new line for readability

      decimal parseCost = decimal.Parse(cost);
      double parseNumber = double.Parse(number);
      int parseYear = int.Parse(year);

      Console.WriteLine("In the year " + parseYear + " BC there was a legend " +
        "about a mythical " + adjectiveOne + " " +foodItemOne + " that was " +
        "said to bring the wielder unlimited " + nounOne + ".");

      Console.WriteLine(" Now after " + parseNumber + " years this legend " +
        "became reality after a " + adjectiveTwo + " rapper named " + nameOne +
        "alongside his partner in crime " + nameTwo + " were looking for " +
        "some " + foodItemTwo +  " to eat.");

      Console.WriteLine("Suddenly " + sound + " a " + adjectiveThree +
        " light shone upon the " + adjectiveOne + " " + foodItemOne + "; " +
        nameOne + " and " + nameTwo + " looked at each other " + expression +
        " not believing what just happened to them. ");

      Console.WriteLine("A note was stuck on the " + foodItemOne + " and " +
        "said the following: whoever wields this " + foodItemOne + " is " +
        "granted unlimited " + nounOne + ", however you must be careful " +
        "because if you " + verbOne + " the " + foodItemOne + ", you will be " +
        "turned into a "  + animalOne);

      Console.WriteLine("The two " + adjectiveFour + " rappers decided to " +
        "test it, they drew " + nounTwo + " to see who would eat it.");

      Console.WriteLine("Unfortunately " + nameTwo +  " got the short " +
        nounTwo + " and had to eat the " + foodItemOne + "; " + "in " +
        "desperation he " + verbTwo + " that a " +  animalTwo + " was " +
        "driving a " + vehicle + "." );

      Console.WriteLine(nameOne + " turned his head to see if " +
        "a " + animalTwo + " was really driving a " + vehicle + "," +
        nameTwo + " used this opportunity to switch the " + foodItemOne +
        " with the " + foodItemTwo + " " + nameOne + " bought beforehand.");

      Console.WriteLine(nameTwo + " apologized because of his bad vision and " +
        "with great confidence he ate the " + foodItemTwo + "; a couple of " +
        "minutes passed  and nothing happened.");

      Console.WriteLine(nameOne + " was disappointed. ");

      Console.WriteLine(nameOne + " reached into his  " + clothes + " to " +
        "grab his food, unawarely he " + verbOne + " the " + foodItemOne +
        " and he was turned into a " + animalOne + ".");

      Console.WriteLine("The cashier ran out of patience and shouted: " +
        "that would be " + parseCost + ".");

      Console.WriteLine("\r\n"); //create a new line for readability

      Console.WriteLine("THE END");
    }
  }
}
