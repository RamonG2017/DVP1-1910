/******************************************************************************
filename   ShirtSizes.cs
author     Ramon Gonzalez Arguello
email      rgonzalezarguello@student.fullsail.edu
course     SDI
section    01
assignment 06         
due date   28/08/2019

 Brief Description:
 the user will be ordering custom t-shirts for their bowling team. They will
 need to figure out how many t-shirts should be ordered for each size.
 Each persons order will be stored in an array element that the computer
 must loop through and count up each size. These quantities cannot be hard
 coded and must work for both test arrays. 
******************************************************************************/

using System;

namespace GonzalezArguello_Ramon_ShirtSizes
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Hello user hope you have had a good day. " +
                        "This program will store the amount of shirts and" +
                        " the sizes of said shirts for your bowling team.");

      //string[] shirtOrders = {"Medium", "Small", "X-Large", "Small", "Large",
      //"Medium", "Small", "X-Large", "XX-Large"};

        //array thatt stores the shirt orders
      string[] shirtOrders = {"XX-Large", "Medium", "Large", "Small", "X-Large",
                              "Small", "Large", "XX-Large", "Large", "XX-Large",
                              "Medium", "Medium" };

        //store the total for small shirts
      int smallSizeTotal = 0;
        
       //store the total for medium shirts
      int mediumSizeTotal = 0;

        //store the total for large shirts
      int largeSizeTotal = 0;

        //store the total for X-Large shirts
      int xLargeSizeTotal = 0;

        //store the total for XX-Large shirts
      int xxLargeSizeTotal = 0;

      for (int i = 0; i < shirtOrders.Length; i++)
      {
        if (shirtOrders[i] == "Small")
        {
            //increase the total for small shirts
          smallSizeTotal += 1;
        }
        else if (shirtOrders[i] == "Medium")
        {
		    //increase the total for medium shirts
		  mediumSizeTotal += 1;
        }
        else if (shirtOrders[i] == "Large")
        {
			//increase the total for large shirts
		  largeSizeTotal += 1;
        }
        else if (shirtOrders[i] == "X-Large")
        {
            //increase the total for X-Large shirts
          xLargeSizeTotal += 1;
        }
        else
        {
            //increase the total for XX-Large shirts
          xxLargeSizeTotal += 1;
        }
      }

      Console.WriteLine("Order " + smallSizeTotal + " Small Shirt(s)");

      Console.WriteLine("Order " + mediumSizeTotal + " Medium Shirt(s)");

      Console.WriteLine("Order " + largeSizeTotal + " Large Shirt(s)");

      Console.WriteLine("Order " + xLargeSizeTotal + " X-Large Shirt(s)");

      Console.WriteLine("Order " +  xxLargeSizeTotal + " XX-Large Shirt(s)");

      /*************************************************************************
       Test #1 results:

       Hello user hope you have had a good day. This program will store the
       amount of shirts and the sizes of said shirts for your bowling team.
       Order 3 Small Shirt(s)
       Order 2 Medium Shirt(s)
       Order 1 Large Shirt(s)
       Order 2 X-Large Shirt(s)
       Order 1 XX-Large Shirt(s)

      *************************************************************************/

      /*************************************************************************
       Test #2 results:

       Hello user hope you have had a good day. This program will store the
       amount of shirts and the sizes of said shirts for your bowling team.
       Order 2 Small Shirt(s)
       Order 3 Medium Shirt(s)
       Order 3 Large Shirt(s)
       Order 1 X-Large Shirt(s)
       Order 3 XX-Large Shirt(s)

      *************************************************************************/
    }
  }
}
