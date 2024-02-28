using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_CircleCylinder
{
    internal class Cylinder : Circle
    {
        protected double height;

        public Cylinder()
        {
            height = 1.0;
        }

        public Cylinder(double radius, double height, string color) : base(radius, color)
        {
            this.height = height;
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double GetVolume()
        {
            return base.GetArea() * height;
        }

        public override double GetArea()
        {
            return Math.Round(2 * Math.PI * radius * height + 2 * base.GetArea(), 2);
        }

        public override string ToString()
        {
            return $"Cylinder[\n  radius = {radius},\n  height = {height}, \n  color = {color},\n  Total area = {GetArea()},\n  Volume = {GetVolume()},\n]";

        }
    }

}
