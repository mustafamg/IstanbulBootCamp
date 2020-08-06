using System.Dynamic;

namespace SRP
{
    public class Triangle: IShapeAreaCalculator
    {
        public Triangle(float baseLength, float height)
        {
            BaseLength = baseLength;
            Height = height;
        }

        private float BaseLength { get; set; } 
        private float Height { get; set; }
                
        public float GetArea()
        {
            return 0.5f * Height * BaseLength;
        }
    }
}
