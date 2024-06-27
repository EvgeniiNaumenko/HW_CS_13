using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13_24_06_2024
{
    public record class Point3D ( int Xcord, int Ycord, int  Zcord)
    {
        public override string ToString()
        {
            return $"Point cords X:{Xcord}, Y:{Ycord}, Z:{Zcord}.";
        }
    }
    public static class PointExtensions
    {
        public static double Distance(this Point3D p1, Point3D p2)
        {
            return Math.Sqrt(Math.Pow(p1.Xcord+p2.Xcord,2)+ Math.Pow(p1.Ycord + p2.Ycord, 2)+ Math.Pow(p1.Zcord + p2.Zcord, 2));
        }
        public static double Distance(this Point3D[] p1)
        {
            double maxDist = 0;
            if (p1.Length >= 2)
            {
                maxDist = Distance(p1[0], p1[1]);
                for (int i = 1; i < p1.Length-1; i++)
                {
                    double nextDist = Distance(p1[i], p1[i + 1]);
                    if (maxDist < nextDist)
                    {
                        maxDist = nextDist;
                    }
                }  
            }
            return maxDist;
        }
        public static void Show(this Point3D[] p1)
        {
            foreach (Point3D p in p1)
            {
                Console.WriteLine(p);
            }
        }
    }
}
