using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
       public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }
       public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
        static void Main()
        {
            Console.WriteLine(GetFileExtension("example"));
            Console.WriteLine(GetFileExtension("example.pdf"));
            Console.WriteLine(GetFileExtension("example.new.pdf"));

            Console.WriteLine(GetFileNameWithoutExtension("example"));
            Console.WriteLine(GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CalculateDistance.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CalculateDistance.CalcDistance3D(5, 2, -1, 3, -6, 4));

            CalculateVolume.Width = 3;
            CalculateVolume.Height = 4;
            CalculateVolume.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", CalculateVolume.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", CalculateDiagonals.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", CalculateDiagonals.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", CalculateDiagonals.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", CalculateDiagonals.CalcDiagonalYZ());
        }

       
    }
}
