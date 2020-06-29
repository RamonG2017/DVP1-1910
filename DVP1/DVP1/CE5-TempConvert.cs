using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //ReadAllLines used to print out text file of ASCII art

// Name: Ramon Gonzalez Arguello
// Date: October 2019   
// CE Name: Coding Exercise 5 - Temp Convert

/*
 * Synopsis: Asks the user for a range of temperature conversions, then validate
 * that the choice is valid and also not left in blank, calls the appropriate
 * conversion method and asks for a temperature and displays the converted
 * temperature. At the end it goes back to the menu
 */

namespace DVP1
{
  public class CE5_TempConvert
  {
    public static void TempConvertStart()
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
                        @"TempConvertHeader.txt";

      //create a string list that stores every individual line of the txt file
      List<string> fileLines = File.ReadAllLines(filePath).ToList();

      //print each line of the string list
      foreach (string line in fileLines)
      {
        Console.WriteLine(line);
      }

      int choice = CE7_Validation.IntegerValidationWithRange(DisplaySelection(),
                                                             1, 6);

      switch (choice)
      {
        case 1:
          FahrenheitToCelsius();
          break;
        case 2:
          CelsiusToFahrenheit();
          break;
        case 3:
          FahrenheitToKelvin();
          break;
        case 4:
          KelvinToFahrenheit();
          break;
        case 5:
          CelsiusToKelvin();
          break;
        case 6:
          KelvinToCelsius();
          break;
      }

      Console.Write("\r\n");

      Console.WriteLine("=============================================" +
                        "=========================");

      Console.Write("Press any key to return to the main menu: ");
    }

    private static void FahrenheitToCelsius()
    {
      //calculate the temparature in kelvin base on the celsius temperature
      int convertedTemperatureCelsius = 0;

      int temperatureFahrenheit = CE7_Validation.IntegerValidation("\r\nOk, " +
                                  "what temperature in Fahrenheit would you" +
                                  " like to convert?");

      //calculate the temparature in Celsius based on the Fahrenheit temperature
      convertedTemperatureCelsius = (temperatureFahrenheit - 32) * 5 / 9;

      Console.WriteLine("\r\n");

      Console.WriteLine("Excellent! " + temperatureFahrenheit + "˚F would be " +
                        convertedTemperatureCelsius + "˚C");
    }

    private static void CelsiusToFahrenheit()
    {
      //calculate the temparature in kelvin base on the celsius temperature
      int convertedTemperatureFahrenheit = 0;

      int temperatureCelsius = CE7_Validation.IntegerValidation("\r\nOk, " +
                                  "what temperature in Celsius would you" +
                                  " like to convert?");

      //calculate the temparature in Fahrenheit based on the Celsius temperature
      convertedTemperatureFahrenheit = (temperatureCelsius * 9/5) + 32;

      Console.WriteLine("\r\n");

      Console.WriteLine("Excellent! " + temperatureCelsius + "˚C would be " +
                        convertedTemperatureFahrenheit + "˚F");

    }

    private static void KelvinToFahrenheit()
    {
      //calculate the temparature in kelvin base on the celsius temperature
      double convertedTemperatureFahrenheit = 0;

      int temperatureKelvin = CE7_Validation.IntegerValidation("\r\nOk, " +
                              "what temperature in Kelvin would you" +
                              " like to convert?");

      //calculate the temparature in Fahrenheit based on the Kelvin temperature
      convertedTemperatureFahrenheit = (temperatureKelvin * 9 / 5) - 459.67;

      Console.WriteLine("\r\n");

      Console.WriteLine("Excellent! " + temperatureKelvin + "˚K would be " +
                        convertedTemperatureFahrenheit + "˚F");

    }

    private static void FahrenheitToKelvin()
    {
      //calculate the temparature in kelvin base on the celsius temperature
      double convertedTemperatureKelvin = 0;

      int temperatureFahrenheit = CE7_Validation.IntegerValidation("\r\nOk, " +
                                  "what temperature in Fahrenheit would you" +
                                  " like to convert?");

      //calculate the temparature in Kelvin based on the Fahrenheit temperature
      convertedTemperatureKelvin = (temperatureFahrenheit + 459.67) * 5 / 9;

      Console.WriteLine("\r\n");

      Console.WriteLine("Excellent! " + temperatureFahrenheit + "˚F would be " +
                        convertedTemperatureKelvin + "˚K");

    }

    private static void KelvinToCelsius()
    {
      //calculate the temparature in kelvin base on the celsius temperature
      double convertedTemperatureCelsius = 0;

      int temperatureKelvin = CE7_Validation.IntegerValidation("\r\nOk, " +
                                  "what temperature in Kelvin would you" +
                                  " like to convert?");

      //calculate the temparature in Celsius based on the Kelvin temperature
      convertedTemperatureCelsius = temperatureKelvin - 273.15;

      Console.WriteLine("\r\n");

      Console.WriteLine("Excellent! " + temperatureKelvin + "˚K would be " +
                        convertedTemperatureCelsius + "˚C");

    }

    private static void CelsiusToKelvin()
    {
      //variable that will store the converted temperature
      double convertedTemperatureKelvin = 0;

      int temperatureCelsius = CE7_Validation.IntegerValidation("\r\nOk, " +
                                  "what temperature in Kelvin would you" +
                                  " like to convert?");

      //calculate the temparature in Kelvin based on the Celsius temperature
      convertedTemperatureKelvin = temperatureCelsius + 273.15;

      Console.WriteLine("\r\n");

      Console.WriteLine("Excellent! " + temperatureCelsius + "˚C would be " +
                        convertedTemperatureKelvin + "˚K");
    }

    private static string DisplaySelection()
    {
      string choiceMenu ="\r\n" + "\r\nWelcome to TempConvert. Would you " +
                         "like to..." + "\r\n1. Convert temperature from " +
                         "Fahrenheit to Celsius" + "\r\n2. Convert " +
                         "temperature from Celsius to Fahrenheit" + "\r\n3. " +
                         "Convert temperature from Fahrenheit to Kelvin" +
                         "\r\n4. Convert temperature from Kelvin " +
                         "to Fahrenheit" + "\r\n5. Convert temperature " +
                         "from Celsius to Kelvin" +
                         "\r\n6. Convert temperature from Kelvin to Celsius";

      return choiceMenu;
    }
  }
}