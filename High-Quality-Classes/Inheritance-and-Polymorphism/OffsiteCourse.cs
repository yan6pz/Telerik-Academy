using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse:Courses
    {
       
        public string Town { get; set; }
     
        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
             :base(courseName,teacherName,students)
        {
                        
        }
        public OffsiteCourse(string courseName, string teacherName)
            :base(courseName,teacherName)
        {
                        
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("OffsiteCourse { ");
            result.Append(base.ToString());

            if (this.Town != null)
            {
                result.AppendFormat("; Town = {0}", this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
