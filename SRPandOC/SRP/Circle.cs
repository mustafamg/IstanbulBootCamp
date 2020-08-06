using System.Dynamic;

namespace SRP
{
    public class Circle: IShapeAreaCalculator
    {
        public Circle(float radius)
        {
            Radius = radius;
        }

        public float Radius { get; set; }
                
        public float GetArea()
        {
            return 3.14f * Radius * Radius;
        }
    }
}
