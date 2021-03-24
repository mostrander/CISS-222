using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
   class Rectangle
   {
      private int length = 0;
      private int width = 0;
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

      public Rectangle (int Length, int Width)
      {
         if (Length > 0 && Width > 0)
         {
            length = Length;
            width = Width;
            valid = true;
         }
         else
         {
            valid = false;
         }
      }


      public double Area()
      {
         area = length * width;
         return area;
      }

      public double Perimeter()
      {
         perimeter = 2 * (length + width);
         return perimeter;
      }
   }
}
