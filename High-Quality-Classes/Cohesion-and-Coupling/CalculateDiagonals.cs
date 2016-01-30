using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CohesionAndCoupling
{
    class CalculateDiagonals : CalculateDistance
    {
         public static double CalcDiagonalXYZ()
        {
            double distance = CalcDistance3D(0, 0, 0, CalculateVolume.Width, CalculateVolume.Height, CalculateVolume.Depth);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = CalcDistance2D(0, 0, CalculateVolume.Width, CalculateVolume.Height);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = CalcDistance2D(0, 0, CalculateVolume.Width, CalculateVolume.Depth);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = CalcDistance2D(0, 0, CalculateVolume.Height, CalculateVolume.Depth);
            return distance;
        }
    
    }
}
