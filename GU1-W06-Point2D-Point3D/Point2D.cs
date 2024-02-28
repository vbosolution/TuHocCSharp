using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Point2D_Point3D
{
    internal class Point2D
    {
        protected float x = 0.0f;
        protected float y = 0.0f;

        public Point2D() { }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetX(float x)
        {
            this.x = x;
        }

        public float GetX()
        {
            return this.x;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public float GetY()
        {
            return this.y;
        }

        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float[] GetXY()
        {
            return new float[] { this.x, this.y };
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y})";
        }
    }

}
