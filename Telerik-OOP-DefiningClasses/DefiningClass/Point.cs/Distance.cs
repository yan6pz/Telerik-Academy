using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point.cs
{
   static class Distance
    {
        public static double DistanceCal(Point first, Point second)
        {
            return Math.Sqrt((first.X - second.X) * (first.X - second.X) + (first.Y - second.Y) * (first.Y - second.Y) + (first.Z - second.Z) * (first.Z - second.Z));
        }
    }
}
