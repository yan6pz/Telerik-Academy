using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFive.cs
{
    class Program
    {
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
            //lambda expresions
            var students =
            names.OrderByDescending(a => a.First)
             .ThenByDescending(a => a.Second);
            //Linq
            //         var students =
            //from n in names
            //orderby n.First descending, n.Second descending
            //select n; 
            foreach (var name in students)
            {
                Console.WriteLine(name.First + " " + name.Second);
            }
        }
    }
}
