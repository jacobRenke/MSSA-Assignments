using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentAttendance
{
    class Student
    {
        public string name { get; private set; }
        public int age { get; private set; }
        public int grade { get; private set; }


        public Student(string name, int age, int grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
    }
    
}
