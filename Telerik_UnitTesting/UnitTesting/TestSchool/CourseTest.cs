using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;
using System.Collections.Generic;

namespace TestSchool
{
    [TestClass]
    public class CourseTest
    {
        [TestMethod]
        public void TestCourseName()
        {
            string name = "Jhonathan";
            Course course = new Course(name);
            Assert.AreEqual(course.Name, name);           
        }

        [TestMethod]
        public void TestCourseStudentAdd()
        {
            Student student = new Student("Mitko Mitev",61614);
            List<Student> list = new List<Student>();
            list.Add(student);
            Assert.IsTrue(list.Contains(student));
        }

        [TestMethod]
        public void TestCourseAddStudent()
        {         
            List<Student> students = new List<Student>();
            Course course = new Course(students);                      
           Student student = new Student("Mitko Mitev", 61614);           
           //Course course = new Course();
           course.AddStudents(student);
           Assert.IsTrue(course.Participants.Contains(student));
        }

        [TestMethod]
        public void TestCourseAddStudents()
        {
            List<Student> students = new List<Student>();
            Course course = new Course(students);
            Student student = new Student("Mitko Mitev", 61614);
            Student student1 = new Student("Krali Marko", 23237);
            course.AddStudents(student1);
            course.AddStudents(student);
            Assert.IsTrue(course.Participants.Count==2);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourseAddStudentTwise()
        {
            List<Student> students = new List<Student>();
            Course course = new Course(students);
            Student student = new Student("Mitko Mitev", 61614);
            Student student1 = new Student("Mitko Mitev", 61614);
            course.AddStudents(student1);
            course.AddStudents(student);
            
        }

        [TestMethod]
        public void TestRemoveStudent()
        {
            List<Student> students = new List<Student>();
            Course course = new Course(students);
            Student student = new Student("Mitko Mitev", 61614);
            Student student1 = new Student("Krali Marko", 23237);
            course.AddStudents(student1);
            course.AddStudents(student);
            course.Remove(student);
            Assert.IsTrue(course.Participants.Count == 1);
        }

        [TestMethod]
        public void TestRemoveStudentt()
        {
            List<Student> students = new List<Student>();
            Course course = new Course(students);
            Student student = new Student("Mitko Mitev", 61614);                       
            course.AddStudents(student);
            course.Remove(student);
            Assert.IsTrue(course.Participants.Count == 0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestRemoveUnexcistingStudent()
        {
            List<Student> students = new List<Student>();
            Course course = new Course(students);
            Student student = new Student("Mitko Mitev", 61614);
            course.Remove(student);
            Assert.IsTrue(course.Participants.Count == 0);
        }
        
        [TestMethod]
        public void TestFindStudent()
        {
            List<Student> students = new List<Student>();
            Course course = new Course(students);           
            Student student = new Student("Mitko Mitev", 61614);
            course.AddStudents(student);
            bool actual = course.IsStudentFound(student);         
            Assert.AreEqual(true,actual);
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAddMoreThanExpected()
        {
            List<Student> students = new List<Student>();
            Course course = new Course(students);
            Student student = new Student("Mitko Mitev", 61614);
            for (int i = 10001; i < 10032; i++)
            {
                course.AddStudents(new Student("Marto",i));
            }                        
            
        }


     
       


    }
}
