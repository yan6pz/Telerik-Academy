using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSix.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1, 3, 5, 7, 9, 13, 2, 5, 14, 18, 21 };
            //lambda

            List<int> newArray = array.FindAll(x => ((x % 3 == 0) && (x % 7 == 0)));

            //linq
            var newArray1 =
            from integer in array
            where integer % 21 == 0
            select integer;
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
