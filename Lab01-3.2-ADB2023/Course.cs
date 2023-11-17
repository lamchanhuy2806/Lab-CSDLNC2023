using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3._2_ADB2023
{
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }

        public Course(string courseCode, string courseName) 
        {
            CourseCode= courseCode;
            CourseName= courseName;
        }
    }
}
