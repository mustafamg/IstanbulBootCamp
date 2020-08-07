﻿using System.Dynamic;

namespace SRP
{
    public class Rectangle: IShapeAreaCalculator, IShapeLongestDimension
    {
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }

        private float Width { get; set; }
        private float Height { get; set; }
                
        public float GetArea()
        {
            return Height * Width;
        }

        public float GetLongestDimension()
        {
            return Width > Height ? Width : Height;
        }
    }
}
