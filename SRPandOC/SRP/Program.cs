namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(5, 4);

            ShapePrinter sp = new ShapePrinter();
            sp.PrintArea(rectangle);

            var circle = new Circle(5);
            sp.PrintArea(circle);

            var square = new Square(5);
            sp.PrintArea(square);


            var tr = new Triangle(5, 4);

            sp.PrintArea(tr);
        }
    }
}
