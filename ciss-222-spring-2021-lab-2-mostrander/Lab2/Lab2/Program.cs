using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
         string input = null;

         //Variable used for user input for creating circle.
         int diameter = 0;

         //Variables used for user input for creating triangle
         int sideOne = 0;
         int sideTwo = 0;
         int sideThree = 0;

         //Variables used for user input for creating rectangle
         int length = 0;
         int width = 0;
         
         //Forces the program to loop through the prompt even if user creates an invalid object or enters an invalid value.
         do
         {
            Console.WriteLine("What shape do you want to create?");
            Console.WriteLine(" - Enter 1 for a circle");
            Console.WriteLine(" - Enter 2 for a triangle");
            Console.WriteLine(" - Enter 3 for a rectangle");
            input = Console.ReadLine();

            switch (input)
            {
               case "1":
                  Console.WriteLine("Enter the diameter of the circle: ");

                  try
                  {
                     diameter = int.Parse(Console.ReadLine());

                     var Circle = new Circle(diameter);
                     if (Circle.IsValid == true)
                     {
                        Console.WriteLine("The circle is valid");
                        Console.WriteLine("The area of the specified circle is: " + Circle.Area());
                        Console.WriteLine("The perimeter of the specified circle is: " + Circle.Perimeter());
                        Console.WriteLine();
                     }
                     else
                     {
                        Console.WriteLine("The circle is not valid");
                        Console.WriteLine();
                     }
                  }
                  catch 
                  {
                     Console.WriteLine("You must enter a whole number for diameter.");
                     Console.WriteLine();
                  }
                  break;

               case "2":
                  try
                  {
                     Console.WriteLine("Enter the length of the first side: ");
                     sideOne = int.Parse(Console.ReadLine());
                     Console.WriteLine("Enter the length of the second side: ");
                     sideTwo = int.Parse(Console.ReadLine());
                     Console.WriteLine("Enter the length of the third side: ");
                     sideThree = int.Parse(Console.ReadLine());

                     var Triangle = new Triangle(sideOne, sideTwo, sideThree);
                     if (Triangle.IsValid == true)
                     {
                        Console.WriteLine("The triangle is valid");
                        Console.WriteLine("The area of the specified triangle is: " + Triangle.Area());
                        Console.WriteLine("The perimeter of the specified triangle is: " + Triangle.Perimeter());
                        Console.WriteLine();
                     }
                     else
                     {
                        Console.WriteLine("The triangle is not valid");
                        Console.WriteLine();
                     }
                  }
                  catch
                  {
                     Console.WriteLine("Please enter whole numbers for the length of side.");
                     Console.WriteLine();
                  }

                  break;

               case "3":
                  try
                  {
                     Console.WriteLine("Enter the length of the rectangle: ");
                     length = int.Parse(Console.ReadLine());
                     Console.WriteLine("Enter the width of the rectangle: ");
                     width = int.Parse(Console.ReadLine());

                     var Rectangle = new Rectangle(length, width);
                     if (Rectangle.IsValid == true)
                     {
                        Console.WriteLine("The rectangle is valid");
                        Console.WriteLine("The area of the specified triangle is: " + Rectangle.Area());
                        Console.WriteLine("The perimeter of the specified triangle is: " + Rectangle.Perimeter());
                        Console.WriteLine();
                     }
                     else
                     {
                        Console.WriteLine("The rectangle is not valid");
                        Console.WriteLine();
                     }
                  }
                  catch
                  {
                     Console.WriteLine("Please enter whole numbers only.");
                     Console.WriteLine();
                  }

                  break;

               case "exit":
                  System.Environment.Exit(0);
                  break;

               default:
                  Console.WriteLine("You did not enter a valid shape number");
                  Console.WriteLine();
                  break;
            }
         }
         while (input != "exit");


      }
   }
}
