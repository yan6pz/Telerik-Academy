using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestStudentName()
        {
            string name = "Mitaka";
            //int number = 65565;
            Student student = new Student(name);
            Assert.AreEqual(student.Name, name);
        }

        [TestMethod]
        public void TestStudentID()
        {
            //string name = "Mitaka";
            int number = 65516;
            Student student = new Student(number);
            Assert.AreEqual(student.CourseNumber, number);
        }

        [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
        public void TestNullName()
        {
            string name = null;
            Student student = new Student(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSmallerId()
        {
            int number = 7777;
            Student student = new Student(number);
           // Assert.IsFalse(number > 10000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBiggerId()
        {
            int number = 777777;
            Student student = new Student(number);
            //Assert.IsFalse(number < 99999);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNegativeId()
        {
            int number = -12345;
            Student student = new Student(number);           
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestNullableId()
        {
            int number = 0;
            Student student = new Student(number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStringId()
        {
            int testName = int.MaxValue;
            Student student = new Student(testName);
        }
    }
}
