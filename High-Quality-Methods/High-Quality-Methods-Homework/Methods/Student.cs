using System;

namespace Methods
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;

        public Student(string firstName,string lastName,string otherInfo)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.otherInfo = otherInfo;
        }

        public string FirstName 
        {
            get { return this.firstName; }

            set { this.firstName = FirstName; }
        }

        public string LastName
        {
            get { return this.lastName; }

            set { this.lastName = LastName; }
        }

        public string OtherInfo
        {
            get { return this.otherInfo; }

            set { this.otherInfo = OtherInfo; }
        }

        

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
           
            DateTime secondDate =
                DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            return firstDate < secondDate;
        }
    }
}
