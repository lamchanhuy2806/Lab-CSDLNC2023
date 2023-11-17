using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3._2_ADB2023
{
    public class Student
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime YearOfAdmission { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public Course Course { get; set; }
        public Student(string id, string firstname, string lastname, DateTime yearofadmission, DateTime dateofbirth, int age, Course course)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            YearOfAdmission = yearofadmission;
            DateOfBirth = dateofbirth;
            Age = age;
            Course = course;
        }
    }
}
