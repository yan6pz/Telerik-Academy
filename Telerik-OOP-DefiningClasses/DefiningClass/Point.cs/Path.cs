using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point.cs
{
    public class Path
    {
        public List<Point> path=new List<Point>(); //declaring path in type list of Points
        public List<Point> Paths       
        {
            get { return this.path; }
            set { this.path = value; }
        }
        public void Adding(Point point1,Point point2,Point point3)
        {
            path.Add(point1);
            path.Add(point2);
            path.Add(point3);
        }
        public void Clear()
        {
            path.Clear();
        }
        public void Print()
        {
            foreach (var item in path)
            {
                Console.WriteLine("{0},{1},{2}",item.X,item.Y,item.Z);
            }
        }

        //internal void Adding(Point pX, Point pY, Point pZ)
        //{
        //    path.Add(pX);
        //    path.Add(pY);
        //    path.Add(pZ);

        //}
    }
}
