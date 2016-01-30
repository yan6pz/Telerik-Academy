using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class School
    {
        public List<Course> courses { get; set; }

        public School(List<Course> course)
        {
            this.courses = course;
        }
    }
}
