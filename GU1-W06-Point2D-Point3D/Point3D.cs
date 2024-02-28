using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GU1_W06_Point2D_Point3D
{
    internal class Point3D : Point2D
    {
        protected float z = 0.0f;

        public Point3D() : base() { }

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }

        public float GetZ()
        {
            return this.z;
        }

        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y); // Sử dụng phương thức từ lớp cơ sở
            this.z = z;
        }

        public float[] GetXYZ()
        {
            return new float[] { this.x, this.y, this.z };
        }

        public override string ToString()
        {
            return $"({this.x}, {this.y}, {this.z})";
        }
    }

}
