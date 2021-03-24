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

            //Keeps the program running while user provides their selection. I know it is not required, 
            //but I do not like programs unexpectedly exiting
            while (userIntReply != 1 && userIntReply != 2 && userIntReply != 3)
            {
               try
               {
                  Console.WriteLine("Welcome to the Dealership! What kind of car are you looking for today?\n" +
                  "\nPlease type the number of your selected choice (i.e. Type \"1\" if you want a specific car).\n" +
                  "1. A specific car. \n2. Any car is fine. \n3. Exit Program\n");

                  userIntReply = int.Parse(Console.ReadLine());
               }
               catch
               {
                  Console.WriteLine("Please only enter the number associated with you choice.");
               }
            }

            if (userIntReply == 1 || userIntReply == 2)
            {
               if (userIntReply == 1)
               {
                  //Ask user for year and color of car they want

                  try
                  {
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
                     }
                  }
                  catch
                  {
                     Console.WriteLine("Please only enter the year as a whole number (i.e. 2015).");
                  }
               }

               else if (userIntReply == 2)
               {
                  //User will be given a random car, with random year (1998 - 2021) and color is automatically red.
                  Car myCar = new Car();

                  Console.WriteLine("Congradulations! You have purchased a car. " +
                     "\nYour car was manufactured in " + myCar.GetYear() + " and it is " + myCar.GetCarColor() + ".");

                  //Allows user to determine what they want to do with vehicle
                  //Has to be included in both myCar creation instances to be able to function properly.
                  //I clear made this too complicated for this assignment.
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
                           else
                           {
                              Console.WriteLine("The car has successfully been turned on.");
                           }
                           break;
                        case "2":
                           Console.WriteLine("How many miles will you drive the car? Please round to the nearest whole number.");
                           userIntReply = int.Parse(Console.ReadLine());
                           result = myCar.Drive(userIntReply).ToString();

                           Console.WriteLine($"Gas left in the tank is {result}");
                           break;
                        case "3":
                           resultBool = myCar.Stop();

                           break;
                        case "4":
                        resultBool = myCar.Park();
                           if (resultBool == false)
                           {
                              Console.WriteLine("The car cannot be parked while it is moving!");
                           }
                           else
                           {
                              Console.WriteLine("The car has been parked.");
                           }
                           break;
                        case "5":
                        resultBool = myCar.TurnOff();
                           break;
                        case "6":
                        result = myCar.CheckCurrentFuelAmount();
                           break;
                        case "7":
                           Console.WriteLine("You spent $" + myCar.AddGas(gasPrice) + " to refill the gas tank.");
                           break;
                        case "8":
                        result = myCar.CheckFuelEfficiency();
                        Console.WriteLine($"Your car has {result}% fuel efficiency.");
                           break;
                        case "9":
                        myCar.ChangeColor(); 
                        break;

                        case "-1":
                           System.Environment.Exit(0); //Ends program
                           break;
                        default:
                           Console.WriteLine("Invalid input. Please try again.");
                           break;
                     }

                  }
               }
            }
            else { System.Environment.Exit(0); } //Program ends


           
        } // End of main method!
    }
}
