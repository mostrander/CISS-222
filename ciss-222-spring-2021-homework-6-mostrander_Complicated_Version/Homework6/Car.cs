using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
   class Car
   {  

      private string color;
      private static int year; // You cannot change the year a particular car was made.

      //tirePressure will be used to determine fuel efficiency, bad pressure results in less efficiency
      //30 miles = 1 gallon, 12 gallon tank default
      private double fuelAmount;
      private static int tankCapacity;

      private double fuelEfficiency; //vehicles before 2010 will have 20% less efficiency automatically
      private int milesUntilRefill; //Helps track number of miles & fuelAmount as car is used.

      //Helps program determine if the car is currently in motion, will be used to validate parking
      private bool moving;
      private bool park; //A car can technically be parked and still on.
      private bool carIsOn;


      //Used when used just wants a random vehicle.
      public Car ()
      {
         //Set default values for a brand new car.
         tankCapacity = 12;
         fuelAmount = 12;
         park = true;
         moving = false;
         carIsOn = false;

         Random vehicleYear = new Random();
         year = vehicleYear.Next(1998, 2021);

         if (year < 2010)
         {
            fuelEfficiency = .80;
         }
         else
         {
            fuelEfficiency = 1;
         }

         //Default car will be red because that is one of the primary colors used.
         color = "red";

         milesUntilRefill = tankCapacity * 30; //360 miles
      }

      //Used when user knows what year and color vehicle they want
      public Car (int Year, string Color)
      {
         year = Year;
         color = Color;

         //Set default values for a brand new car.
         tankCapacity = 12;
         fuelAmount = 12;
         park = true;
         moving = false;
         carIsOn = false;

         if (year < 2010)
         {
            fuelEfficiency = .80; //80%
         }
         else
         {
            fuelEfficiency = 1; //100%
         }

         milesUntilRefill = tankCapacity * 30; //360 miles
      }



      public bool Park ()
      {
         if(moving == true)
         {
            //You cannot park a car that is moving.
            return false;
         }
         else
         {
            park = true;
            return true;
         }
      }

      public bool Stop ()
      {
         if (moving == true)
         {
            moving = false;
            return true;
         }
         else
         {
            //You cannot stop the car if it is not moving.
            return false;
         }
         
      }

      public bool TurnOff ()
      {
         if (carIsOn == false)
         {
            //You cannot turn off a car that is already off.
            return false;
         }
         else if(moving == true || park != true)
         {
            //Car needs to be parked before it can be turned off, which requires it to not be moving.
            return false;
         }
         else 
         {
            carIsOn = false;
            return true;
         }
      }


      //Calculates how much is spent to refuel the car based on current prices provided by user.
      public decimal AddGas (decimal gasFee)
      {
         decimal moneyCharged;
         moneyCharged = gasFee * (decimal)(tankCapacity - fuelAmount);

         milesUntilRefill = 360; //reset number of miles until car must be refilled

         return moneyCharged;
      }


      public void ChangeColor ()
      {
         Console.WriteLine("1. Red \n2. Blue \n3. White \n4. Silver \n5. Black\n");
         string choice = Console.ReadLine();

         switch (choice)
         {
            case "1":
               color = "red";
               break;
            case "2":
               color = "blue";
               break;
            case "3":
               color = "white";
               break;
            case "4":
               color = "silver";
               break;
            case "5":
               color = "black";
               break;

            default:
               Console.WriteLine("We apologize. We do not currently offer that color.");
               break;
         }
      }


      public bool Start ()
      {
         if (fuelAmount == 0.0 || carIsOn == true)
         {
            return false;
         }
         else
         {
            carIsOn = true;
            return true;
         }
      }


      public double Drive (int miles)
      {
         moving = true;
         park = false;

         double gasUsed = miles / 30.0; //30 miles = 1 gallon of gas
         if (fuelEfficiency < 1)
         {
            double wastedGas = gasUsed - (gasUsed * fuelEfficiency);
            gasUsed = gasUsed + wastedGas; //Accounts for additional gas used due to inefficiency.
         }

         fuelAmount = fuelAmount - gasUsed;
         milesUntilRefill = milesUntilRefill - miles; 

         return fuelAmount;
      }


      //List of all of the Get methods for outputting object information

      public string GetYear ()
      {
         return year.ToString();
      }

      public string CheckCurrentFuelAmount ()
      {
         return fuelAmount.ToString();
      }

      public string CheckFuelEfficiency ()
      {
         double efficiency = fuelEfficiency * 100; //Efficiency should show as a percentage %
         return efficiency.ToString();
      }

      public string GetMilesBeforeNextRefill ()
      {
         return milesUntilRefill.ToString();
      }

      public string GetCarColor ()
      {
         return color;
      }




   }

}
