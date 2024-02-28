using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Shapes
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double length;

        public Rectangle() : base()
        {
            width = length = 1.0;
        }

        public Rectangle(double width, double length) : base()
        {
            this.width = width;
            this.length = length;
        }

        public Rectangle(double width, double length, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }

        public virtual double Width
        {
            get { return width; }
            set { width = value; }
        }

        public virtual double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double GetArea()
        {
            return width * length;
        }

        public double GetPerimeter()
        {
            return 2 * (width + length);
        }

        public override string ToString()
        {
            return $"A Rectangle with width={width} and length={length}, which is a subclass of {base.ToString()}";
        }
    }

}
