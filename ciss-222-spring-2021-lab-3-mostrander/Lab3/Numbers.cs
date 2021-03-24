using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
   class Numbers
   {
      private int largestNumber;
      private int secondLargest;
      private int totalEnteredCount = 0;

      public void EnterNumber ()
      {

         int input;
         string response = "0";

         while (response.ToString() != "q")
         {

            Console.WriteLine("Enter in an integer, or enter q to stop:");
            response = Console.ReadLine();

            try
            {
               input = int.Parse(response);

               if (input > largestNumber)
               {
                  //Move previous largest value to become the second largest, and replace with new value.
                  secondLargest = largestNumber;
                  largestNumber = input;
               }
               totalEnteredCount++;
            }
            catch
            {
               if(response == "q")
               {
                  //Leave lank because it will return control to mail method.
               }
               else
               {
                  Console.WriteLine("Sorry, that is not an integer.");
               }

            }
         }

      }


      public string GetLargestNum()
      {
         return largestNumber.ToString();
      }

      public string GetSecondLargestNum()
      {
         return secondLargest.ToString();
      }

      public string GetTotalEnteredNum()
      {
         return totalEnteredCount.ToString();
      }
   }
}
