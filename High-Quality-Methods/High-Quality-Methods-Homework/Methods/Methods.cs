using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("The sides of the triangle accept negetive value");
            }
            double halfPeremeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPeremeter * (halfPeremeter - a) * (halfPeremeter - b) * (halfPeremeter - c));
            return area;
        }

        static string NumberToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Invalid number!";
            }

            
        }

        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("You have to put some datum in the elements array");
            }
            int i;
            int max = elements[0];
            for ( i=1 ; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "f": Console.WriteLine("{0:f2}", number);
                    break;
                case "%": Console.WriteLine("{0:p0}", number);
                    break;
                case "r": Console.WriteLine("{0,8}", number);
                    break;
            }
        }

        //temporal cohesion
        static double CalcDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (firstPointY == secondPointY);
            isVertical = (firstPointX == secondPointX);

            double distance = Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX)
                                     + (secondPointY - firstPointY) * (secondPointY - firstPointY));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToString(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", "From Sofia, born at 17.03.1992");

            Student stella = new Student("Stella", "Markova", "From Vidin, gamer, high results, born at 03.11.1993");
            
            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
