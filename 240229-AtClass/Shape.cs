using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240229_AtClass
{
    internal abstract class Shape
    {
        public Shape() { }
        public abstract double Area();
        public abstract double Perimeter();

        public virtual bool Equals(object obj)
        {
            if (obj is Shape shape)
            {
                return shape.Area() == Area() && shape.Perimeter() == Perimeter();
            } else
            {
                return false;
            }
        }
    }
    internal class Circle : Shape
    {
        double radius;
        public Circle() {
            radius = 1.0;
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
        public override double Perimeter()
        {
            return 2 *radius * Math.PI;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return $"Circle - r = {radius};\nS = {Math.Round(Area(), 2)}; P = {Math.Round(Perimeter(), 2)}";
        }
    }
    internal class Rectangle : Shape
    {
        double width;
        double height;
        public Rectangle() {
            width = 20.0f;
            height = 30.0f;
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width * height;
        }
        public override double Perimeter()
        {
            return 2 * (width + height);
        }
        public override string ToString()
        {
            return $"Rectangle - w x h = {width} x {height};\nS = {Area()}; P = {Perimeter()}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
