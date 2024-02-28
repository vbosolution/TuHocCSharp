using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_CircleCylinder
{
    internal class Circle
    {
        protected double radius;
        protected string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public virtual double GetArea()
        {
            return Math.Round(Math.PI * radius * radius, 2);
        }

        public override string ToString()
        {
            return $"Circle[\n  radius = {radius}, \n  color = {color},\n  area = {GetArea()},\n]";
        }
    }
}

