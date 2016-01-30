using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    public class Student
    {
        private string name;
        private int courseNumber;

        public Student(string name)
        {
            this.Name = name;
            
        }

        public Student(int courseNumber)
        {           
            this.CourseNumber = courseNumber;
        }

        public Student(string name, int courseNumber)
        {
            this.Name = name;
            this.CourseNumber = courseNumber;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentNullException("There isn't appropiate name");
                }
            }
        }

        public int CourseNumber
        {
            get { return this.courseNumber; }
            set
            {
                if ((value > 10000) && (value < 99999))
                {
                    this.courseNumber = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value of the courseNumber must be from 10000 to 99999");
                }
            }
        }
    }
}
