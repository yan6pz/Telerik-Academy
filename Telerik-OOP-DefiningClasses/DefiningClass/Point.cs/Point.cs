using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}. Add a static property to return the point O.

namespace Point.cs
{
    public struct  Point
    {
        public int X{get; set;}
        public int Y{get; set;}
        public int Z { get; set; }
        private static readonly Point start = new Point(0, 0, 0);
        private int p;
        public Point(int X, int Y, int Z)
            :this()  //defining 3d point with it's three coordinates
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public Point(int p)
            : this()
        {
            // TODO: Complete member initialization
            this.p = p;
        }

       
        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})",X,Y,Z);
        }
        public static Point Start
        {
            get { return start; }
        }
        
    }
}
