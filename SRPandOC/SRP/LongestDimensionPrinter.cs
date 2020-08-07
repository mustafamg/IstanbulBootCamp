using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public class LongestDimensionPrinter
    {
        public void Print(IShapeLongestDimension shape)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The Longest dimension is:" + shape.GetLongestDimension());
            Console.ForegroundColor = color;
        }
    }
}
