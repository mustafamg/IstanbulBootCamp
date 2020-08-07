using System.Dynamic;

namespace SRP
{
    public class PlaplaShape : IShapeAreaCalculator, IShapeLongestDimension
    {
        public PlaplaShape(float radius)
        {
            Radius = radius;
        }

        public float Radius { get; set; }
                
        public float GetArea()
        {
            return Radius * Radius/2-5;
        }

        public float GetLongestDimension()
        {
            return Radius;
        }
    }
}
