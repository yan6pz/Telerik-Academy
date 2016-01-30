using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondTask.cs
{
    public static class IEnum
    {
        public static T Sum<T>(this IEnumerable<T> enter)
        {
            dynamic sum = 0;
            foreach (var element in enter)
            {
                sum += element;
            }
            return sum;
        }
        public static T Product<T>(this IEnumerable<T> enter)
        {
            dynamic prod = 1;
            foreach (var element in enter)
            {
                prod *= element;
            }
            return prod;
        }
        public static T Min<T>(this IEnumerable<T> enter)
        {
            dynamic min = long.MaxValue;
            foreach (var element in enter)
            {
                if (element < min) min = element;
            }
            return min;
        }
        public static T Max<T>(this IEnumerable<T> enter)
        {
            dynamic max = long.MinValue;
            foreach (var element in enter)
            {
                if (element > max) max = element;
            }
            return max;
        }
        public static T Average<T>(this IEnumerable<T> enter)
        {
            dynamic sum = 0;
            int br = 0;
            foreach (var element in enter)
            {
                sum += element;
                br++;
            }
            return sum / br;
        }


    }
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of elements");
            int n = int.Parse(Console.ReadLine());
            long[] elements = new long[n];
            for (int i = 0; i < n; i++)
            {
                elements[i] = long.Parse(Console.ReadLine());
            }
            Console.WriteLine("The sum is:"+ elements.Sum());
            Console.WriteLine("the product is:"+elements.Product());
            Console.WriteLine("Min value is:"+elements.Min());
            Console.WriteLine("Max value is:"+elements.Max());
            Console.WriteLine("Average sum is:"+elements.Average());
        }
    }
}
