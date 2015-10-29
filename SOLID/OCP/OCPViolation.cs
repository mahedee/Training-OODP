using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.Violation
{
    //1st Way
    public class Shape
    {
        //if rectangle
        //if triangle
        //if circle
    }
    //Another Way
    public class Rectangle
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double CalculateArea()
        {
            return Height * Width;
        }
    }

    public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double vbase, double vheight)
        {
            this.Base = vbase;
            this.Height = vheight;
        }

        public double CalculateArea()
        {
            return 1 / 2.0 * Base * Height;
        }
    }
    public class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
