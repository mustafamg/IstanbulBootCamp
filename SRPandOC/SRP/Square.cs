using System.Dynamic;

namespace SRP
{
    public class Square: IShapeAreaCalculator, IShapeLongestDimension
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

        public float GetLongestDimension()
        {
            return Length;
        }
    }
}
