using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
         Numbers test = new Numbers();
         test.EnterNumber();

         Console.WriteLine("The total number of integers entered is: " + test.GetTotalEnteredNum());
         Console.WriteLine("The highest integer entered is: " + test.GetLargestNum());
         Console.WriteLine("The second highest integer entered is: " + test.GetSecondLargestNum());

      }
    }
}
