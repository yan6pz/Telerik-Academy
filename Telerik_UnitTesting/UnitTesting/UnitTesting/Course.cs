using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
   public class Course
    {
        private const int MAX_STUDENTS_CLASS = 30;
        private string name;
        public List<Student> Participants { get; set; }

        public Course()
        {            
        }

        public Course(string name)
        {
            this.Name = name;          
        }

        public Course( List<Student> participants)
        {           
            this.Participants = participants;
        }

        public Course(string name, List<Student> participants)
        {
            this.Name = name;
            this.Participants = participants;
        }

        public string Name
        {
            get{return this.name ;}
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Please enter name of course");
                }
            }
        }

        public void AddStudents(Student student)
        {
            bool found = this.IsStudentFound(student);
            if(found)
            {
                throw new ArgumentException("This student is already in the course");
            }
            else if (Participants.Count < MAX_STUDENTS_CLASS)
            {
                this.Participants.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("There are not more free positions for the course ");
            }
        }

        public void Remove(Student student)
        {
            bool found = this.IsStudentFound(student);

            if (!found)
            {
                throw new ArgumentException("There is not such a student");                
            }
            else
            {
                Participants.Remove(student);
            }
        }

        public bool IsStudentFound(Student student)
        {
            bool found = false;
            for (int i = 0; i < Participants.Count; i++)
            {
                if (this.Participants[i].CourseNumber == student.CourseNumber)
                {
                    found = true;
                }
               
            }
            return found;
        }
            
   }
}
