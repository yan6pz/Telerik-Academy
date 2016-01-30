using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.cs
{
    class Program
    {

        //public static void Students(string[] names)
        //{
        //    var sorted =
        //        from name in names
        //        where names.First.CompareTo(Second) == -1
        //        select (name.First + " " + name.Last);
        //    foreach (var item in sorted)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        static void Main(string[] args)
        {
            var names = new[]{
             new{First="Anton",Second="Petleshjov"},
             new{First="Gabriela",Second="Gincheva"},
             new{First="Vladimir",Second="Petrov"},
             new{First="Gresha",Second="Stoilov"},
             new{First="Shterev",Second="Qnislavov"},
             new{First="Anna",Second="Hezmakian"},
             new{First="Huang",Second="Hu"},
             new{First="Borislav",Second="Nakov"},
             };
            var sorted =
              from name in names
              where name.First.CompareTo(name.Second) == -1
              select name;
            foreach (var name in sorted)
            {
                Console.WriteLine(name.First+ " "+name.Second);
            }

        }
    }
}
