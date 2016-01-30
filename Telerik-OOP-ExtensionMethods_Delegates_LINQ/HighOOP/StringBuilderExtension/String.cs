using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTask.cs
{
    public static class StringBuilderExtension
    {
        public static List<char> SubStringOne(this StringBuilder str, int index, int length)
        {
            List<char> strbuild = new List<char>();
            string str1 = str.ToString();
            if (index + length >= str.ToString().Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = index; i < index + length; i++)
                strbuild.Add(str1[i]);
            return strbuild;

        }
    }
    class Program
    {
        static void Main()
        {
            int index = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            StringBuilder input=new StringBuilder();
            input.SubStringOne(index,length);
        }
    }
}

