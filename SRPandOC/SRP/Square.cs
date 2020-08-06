using System.Dynamic;

namespace SRP
{
    public class Square: IShapeAreaCalculator
    {
        public Square(float lenght)
        {
            Length = lenght;
        }

        public float Length { get; set; }
                
        public float GetArea()
        {
            return Length * Length;
        }
    }
}
