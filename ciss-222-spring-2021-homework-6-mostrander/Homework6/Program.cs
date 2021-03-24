using System;

namespace Homework6
{
    class Program
    {
      static decimal gasPrice = 2.26m;

        static void Main(string[] args)
        {
            int userIntReply = 0;
            string userStringReply = null;
            string result = null;
            bool resultBool = false;


            //Ask user for year and color of car they want

            try
            {
            Console.WriteLine("Welcome to the Dealership!");
               Console.WriteLine("What year was your desired car manufactured? (YYYY)\n" +
                  "We offer cars from the years 1998 - 2021.");
               userIntReply = int.Parse(Console.ReadLine());

               if (userIntReply < 1998)
               {
                  Console.WriteLine($"We apologize. We do not sell vehicles prior to {userIntReply}.\n" +
                     $"Have a good day.");
                  System.Environment.Exit(0); //Ends program
               }
               else if (userIntReply > 2021)
               {
                  Console.WriteLine($"We apologize. {userIntReply} vehicles have not been manufactured yet.\n" +
                     $"Please return at a later date when they have been produced. Have a good day.");
                  System.Environment.Exit(0); //Ends program
               }
               else
               {
                  Console.WriteLine("What color is your desired car?");
                  userStringReply = Console.ReadLine();

                  Car myCar = new Car(userIntReply, userStringReply);

                  Console.WriteLine("Congradulations! You have purchased a car. " +
                     "\nYour car was manufactured in " + myCar.GetYear() + " and it is " + myCar.GetCarColor() + ".");


                  while (userStringReply != "-1")
                  {
                     Console.WriteLine("What would you like to do with your new car?\n" +
                        "1. Start the car.\n" +
                        "2. Drive the car.\n" +
                        "3. Stop the car.\n" +
                        "4. Park the car.\n" +
                        "5. Turn off the car.\n" +
                        "6. Check gas left in the tank.\n" +
                        "7. Add gas to the tank.\n" +
                        "8. Check fuel efficieny.\n" +
                        "9. Change the color of the car.\n" +
                        "-1 to exit the program.\n");
                     userStringReply = Console.ReadLine();

                  switch (userStringReply)
                  {
                        case "1":
                           resultBool = myCar.Start();
                           if (resultBool == false)
                           {
                              Console.WriteLine("The car cannot be started. Please verify that you have enough gas and " +
                                 "the car is not already turned on.");
                           }
                           else { Console.WriteLine("The car has successfully been turned on.\n"); }
                           break;

                        case "2":
                           Console.WriteLine("How many miles will you drive the car? Please round to the nearest whole number.");
                           userIntReply = int.Parse(Console.ReadLine());
                           result = myCar.Drive(userIntReply).ToString("F2");

                           Console.WriteLine($"Gas left in the tank is {result} gallons.\n");
                           break;

                        case "3":
                           resultBool = myCar.Stop();
                           if (resultBool == false)
                           {
                              Console.WriteLine("The car is not currently moving.");
                           } else { Console.WriteLine("The car has stopped moving.\n"); }
                           break;

                        case "4":
                           resultBool = myCar.Park();
                           if (resultBool == false)
                           {
                              Console.WriteLine("The car cannot be parked while it is moving!\n");
                           }
                           else
                           {
                              Console.WriteLine("The car has been parked.\n");
                           }
                           break;

                        case "5":
                           resultBool = myCar.TurnOff();
                           if (resultBool == false)
                           {
                              Console.WriteLine("Cannot turn off the car. Please verify the car as been parked and if the car is still on.\n");
                           }
                           else { Console.WriteLine("The car has been turned off.\n"); }
                           break;

                        case "6":
                           result = myCar.CheckCurrentFuelAmount();
                           Console.WriteLine($"Your fuel tank is currently at {result} out of 12 gallons.\n");
                           break;

                        case "7":
                           Console.WriteLine("You spent " + myCar.AddGas(gasPrice).ToString("C") + " to refill the gas tank.\n");
                           break;

                        case "8":
                           result = myCar.CheckFuelEfficiency();
                           Console.WriteLine($"Your car has {result}% fuel efficiency.\n");
                           break;

                        case "9":
                           myCar.ChangeColor();
                           break;

                        case "-1":
                           System.Environment.Exit(0); //Ends program
                           break;
                        default:
                           Console.WriteLine("Invalid input. Please try again.\n");
                           break;
                     }
                  } //End of while statement
               }
            }

            catch
            {
               Console.WriteLine("Please only enter the year as a whole number (i.e. 2015).");
            }

        } // End of main method!
    }
}
