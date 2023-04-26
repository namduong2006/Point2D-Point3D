using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D_Point3D
{
    internal class Point2D
    {
        float x = 0.0f;
        float y = 0.0f;
        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Point2D()
        {           
        }
        public float GetX()
        {
            return x;
        }
        public void SetX(float x)
        {

            this.x = x;
        }
        public float GetY()
        {
            return y;
        }
        public void SetY(float y)
        {

            this.y = y;
        }
        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void GetXY()
        {
            Console.WriteLine($"{x},{y}");
        }
        public override string ToString()
        {
            return $"x={x},y={y}";
        }

    }
    class Point3D : Point2D
    {
        float z = 0.0f;
        public Point3D()
        {
        }
        public Point3D(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.z = z;
        }
        public float GetZ() 
        { 
            return z;
        }
        public void SetZ(float z)
        {
            this.z = z;
        }
        public void GetXYZ()
        {
            Console.WriteLine($"{X},{Y},{z}");
        }
        public void SetXYZ(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.z = z;
        }
        public override string ToString()
        {
            return $"x={X},y={Y},z={z}";
        }
    }
    
}
