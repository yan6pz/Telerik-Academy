using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new[]{
             new{First="Anton", Second="Petleshjov",Age=19},
             new{First="Gabriela", Second="Gincheva",Age=14},
             new{First="Vladimir", Second="Petrov",Age=29},
             new{First="Gresha", Second="Stoilov",Age=16},
             new{First="Shterev",Second="Qnislavov",Age=17},
             new{First="Anna", Second="Hezmakian",Age=18},
             new{First="Huang", Second="Hu",Age=21},
             new{First="Borislav", Second="Nakov",Age=23},
             };
            var find =from  student in students
                where student.Age >= 18 && student.Age <= 24
                select student;

            foreach (var student in find)
            {
                Console.WriteLine("Students with age between 18 and 24 are:{0} {1} ", student.First,student.Second); 
            }
            
        }
    }
}
