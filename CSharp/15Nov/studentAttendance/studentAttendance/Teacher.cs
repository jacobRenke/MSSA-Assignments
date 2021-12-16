using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentAttendance
{
    class Teacher
    {
        public string name { get; private set; }
        public int age { get; private set; }

        public delegate void presence();

        public event presence OnStudentMissing;

        public Teacher(string name, int age)
        {
            this.name = name;
            this.age = age;
            OnStudentMissing = teacherYell; 
            OnStudentMissing += studentFail;
        }

        public void teacherYell()
        {
            Console.WriteLine("Where the !@#$ are you???");
        }
        
        public void studentFail()
        {
            Console.WriteLine("You fail.");
        }

        public void takeAttendance(List<Student> attendanceRoster)
        {
            for (int i = 0; i < attendanceRoster.Count; i++)
            {
                Console.WriteLine(attendanceRoster[i].name);
                Console.WriteLine("Is this student present?");
                string answer = Console.ReadLine();
                if (answer == "Yes" || answer == "yes")
                {

                }
                else
                {
                    OnStudentMissing();
                }
            }
        }
    }
}
