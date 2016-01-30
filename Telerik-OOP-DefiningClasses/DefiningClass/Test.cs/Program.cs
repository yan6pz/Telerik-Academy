using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point.cs
{
   public class Program //public to be reachable by every other class in solution
    {
        static void Main(string[] args)
        {
            Path q=new Path();
            q.Adding(new Point(1, 2, 3),new Point(-1,-2,-3),new Point(-10,0,10));
            PathStorage.Save(q);
            Path output = PathStorage.Load();
            output.Print(); 
        }
    }
}
