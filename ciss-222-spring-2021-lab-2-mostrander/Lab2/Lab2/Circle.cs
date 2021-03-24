using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
   class Circle
   {
      private int diameter = 0;
      private double radius = 0;
      private double area = 0;
      private double perimeter = 0;
      private bool valid = false;

      public bool IsValid
      {
         get
         {
            return valid;
         }

      }


      public Circle (int Diameter)
      {
         if ( Diameter > 0)
         {
            diameter = Diameter;
            radius = (double)diameter / (double)2;
            valid = true;
         }
         else
         {
            valid = false;
         }
      }

      public double Area ()
      {
         area = Math.PI * Math.Pow(radius, 2);
         return area;
      }

      public double Perimeter ()
      {
         perimeter = 2 * Math.PI * radius;
         return perimeter;
      }

   }
}
