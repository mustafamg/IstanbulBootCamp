namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeAreaPrinter sp = new ShapeAreaPrinter();
            var longestDimensionPrinter = new LongestDimensionPrinter();

            var rectangle = new Rectangle(5, 4);
            sp.PrintArea(rectangle);
            longestDimensionPrinter.Print(rectangle);

            var circle = new Circle(5);
            sp.PrintArea(circle);

            var square = new Square(5);
            sp.PrintArea(square);
            longestDimensionPrinter.Print(square);


            var tr = new Triangle(5, 4);

            sp.PrintArea(tr);
            longestDimensionPrinter.Print(tr);


            var plapla = new PlaplaShape(5);
            sp.PrintArea(plapla);
            longestDimensionPrinter.Print(plapla);

        }
    }
}
