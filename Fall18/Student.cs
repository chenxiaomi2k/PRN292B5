using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fall18
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public Student()
        {
        }

        public Student(int id, string name, DateTime dOB)
        {
            Id = id;
            Name = name;
            DOB = dOB;
        }

        public int GetAge()
        {
            int yearDob = DOB.Year;
            DateTime dateTime = DateTime.Now;
            int age = dateTime.Year;
            return age - yearDob;
        }

        public override string ToString()
        {
            return $"Student's Information: ID: {Id} - Name: {Name} - Age: {GetAge()}";
        }
    }
}
