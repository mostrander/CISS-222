using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
   class Triangle
   {
      private bool valid = false;
      private int sideOne = 0;
      private int sideTwo = 0;
      private int sideThree = 0;
      private double area = 0;
      private double perimeter = 0;

      public bool IsValid
      {
         get
         {
            return valid;
         }

      }


      public Triangle (int firstSide, int secondSide, int thirdSide)
      {
         if (firstSide > 0 && secondSide > 0 && thirdSide > 0)
         {
            //The sum of any two sides must be greater than the third in any combination of the third sides.
            if ((firstSide + secondSide) > thirdSide 
               && (secondSide + thirdSide) > firstSide 
               && (firstSide + thirdSide) > secondSide)
               {
                  sideOne = firstSide;
                  sideTwo = secondSide;
                  sideThree = thirdSide;
                  valid = true;
               }
            else
            {
               valid = false;
            }

         }
         else
         {
            valid = false;
         }
      }


      public double Area()
      {
         double s = (sideOne + sideTwo + sideThree) / (double) 2;
         double test = s * (s - sideOne) * (s - sideTwo) * (s - sideThree);
         area = Math.Sqrt(test);
         return area;
      }


      public double Perimeter()
      {
         perimeter = sideOne + sideTwo + sideThree;
         return perimeter;
      }
   }
}
