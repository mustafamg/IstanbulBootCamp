using System.Dynamic;

namespace SRP
{
    public class PlaplaShape : IShapeAreaCalculator
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
    }
}
