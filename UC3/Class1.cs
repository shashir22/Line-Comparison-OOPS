﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison_Oops
{
    class UC3_CheckTwoLines
    {
        public static void getCartesian()
        {
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            double length1, length2;
            Console.WriteLine("Enter the points of line1");
            Console.WriteLine("Enter points (x1,y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter points (x2,y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the points of line2");
            Console.WriteLine("Enter points (a1,b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter points (a2,b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            length1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            length2 = Math.Sqrt(((a2 - a1) * (a2 - a1)) + ((b2 - b1) * (b2 - b1)));

            if (length1.Equals(length2))
            {
                Console.WriteLine("The length of two lines are equal");
            }
            else if (length1.CompareTo(length2) < 0)
            {
                Console.WriteLine("The length of line 1 is lesser than line 2");
            }
            else if (length1.CompareTo(length2) > 0)
            {
                Console.WriteLine("The length of line 1 is greater than line 2");
            }
        }
    }
}