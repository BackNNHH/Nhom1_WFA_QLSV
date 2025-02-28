using System;
using System.Collections.Generic;

namespace StudentManagement
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string MSSV { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public Dictionary<string, double> Grades { get; set; }
    }
}
