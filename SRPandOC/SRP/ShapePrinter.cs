using System;

namespace SRP
{
    public  class ShapePrinter
    {
        public void PrintArea(IShapeAreaCalculator shape)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The area is:" + shape.GetArea());
            Console.ForegroundColor = color;
        }
    }
}
