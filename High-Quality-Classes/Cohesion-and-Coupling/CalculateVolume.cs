using System;

namespace CohesionAndCoupling
{
    public class CalculateVolume
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }


       public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

    }
}
