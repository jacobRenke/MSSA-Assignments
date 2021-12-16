using System;

namespace School
{
    class Teacher
    {
        // Fields
        private int id;
        private string className;
        // Constructor
        public Teacher(ref int teacher, ref int employee, Courses[] classList)
        {
            employee++;
            teacher++;
            this.id = teacher;
            Random rnd = new Random();
            int next = rnd.Next(0, 4);
            this.className = classList[next].getClassName();

        }

        public void getTeacherAssignment()
        {
            Console.WriteLine(this.className);
        }
    }
}
