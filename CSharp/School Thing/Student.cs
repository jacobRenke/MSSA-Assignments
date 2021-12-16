using System;

namespace School
{
    class Student
    {
        // Fields
        private int id;
        private string className;

        // Constructor
        public Student(ref int student, Courses[] classList)
        {
            student++;
            this.id = student;
            Random rnd = new Random();
            int next = rnd.Next(0, 4);
            this.className = classList[next].getClassName();
        }
        public void getStudentAssignment()
        {
            Console.WriteLine(this.className);
        }
    }
}

