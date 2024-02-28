using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Shapes
{
    public class Shape
    {
        protected string color;
        protected bool filled;

        public Shape()
        {
            color = "green";
            filled = true;
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool Filled
        {
            get { return filled; }
            set { filled = value; }
        }

        public override string ToString()
        {
            return $"A Shape with color of {color} and {(filled ? "filled" : "not filled")}.";
        }
    }

}
