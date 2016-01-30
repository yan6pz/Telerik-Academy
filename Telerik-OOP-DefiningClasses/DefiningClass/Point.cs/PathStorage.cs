using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point.cs
{
    public static class PathStorage
    {
        public static void Save(Path param)
        {
            using(StreamWriter write=new StreamWriter(@"../../PointLoad.txt"))
            {
                foreach(var item in param.Paths)
                {
                    write.WriteLine(String.Format("{0},{1},{2}",item.X,item.Y,item.Z));
                }
            }
        }
        public static Path Load()
        {
            Path load = new Path();
            using (StreamReader read = new StreamReader(@"../../PointLoad.txt"))
            {
                char [] symbols=new char[]{'(',')',','};
                 string line = read.ReadLine();
                while (line != null)
                {
                    string[] newLine = line.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
                    Point X=new Point(int.Parse(newLine[0]));
                    Point Y=new Point(int.Parse(newLine[1]));
                    Point Z=new Point(int.Parse(newLine[2]));

                    load.Adding(X,Y,Z);
                    

                    line = read.ReadLine();
                }
            }
            return load;
        }
    }
}
    

