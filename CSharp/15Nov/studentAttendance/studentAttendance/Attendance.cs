using System;
using System.Collections.Generic;

namespace studentAttendance
{
    class Attendance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name and age for Teacher 1.");
            string name = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            Teacher teacher1 = new Teacher(name, age);
            Console.WriteLine("Please enter a name and age and grade for Student 1.");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            int grade = Convert.ToInt32(Console.ReadLine());
            Student student1 = new Student(name, age, grade);
            Console.WriteLine("Please enter a name and age and grade for Student 2.");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            grade = Convert.ToInt32(Console.ReadLine());
            Student student2 = new Student(name, age, grade);
            Console.WriteLine("Please enter a name and age and grade for Student 3.");
            name = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            grade = Convert.ToInt32(Console.ReadLine());
            Student student3 = new Student(name, age, grade);

            List<Student> attendanceRoster = new List<Student>();
            attendanceRoster.Add(student1);
            attendanceRoster.Add(student2);
            attendanceRoster.Add(student3);

            teacher1.takeAttendance(attendanceRoster);
            
        }
    }
}
