using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D_Point3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D();           
            point2D.SetXY(3, 5);
            point2D.GetXY();
            Console.WriteLine(point2D.ToString()); 
            Point3D point3D = new Point3D();
            point3D.SetXYZ(5, 7, 9);
            point3D.GetXYZ();
            Console.WriteLine(point3D.ToString());
            Console.ReadLine();
        }
    }
}
