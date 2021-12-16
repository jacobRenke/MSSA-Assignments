using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            setClasses(out Courses Math, out Courses Science, out Courses History, out Courses PE, out Courses[] classList);

            Console.WriteLine(Personnel.getStudents());
            Student student_1 = new Student(ref Personnel.students, classList);
            Student student_2 = new Student(ref Personnel.students, classList);
            Student student_3 = new Student(ref Personnel.students, classList);
            Student student_4 = new Student(ref Personnel.students, classList);
            Student student_5 = new Student(ref Personnel.students, classList);
            Console.WriteLine(Personnel.getStudents());
            student_1.getStudentAssignment();
            student_2.getStudentAssignment();
            student_3.getStudentAssignment();
            student_4.getStudentAssignment();
            student_5.getStudentAssignment();

            Console.WriteLine(Personnel.getTeacher());
            Teacher teacher_1 = new Teacher(ref Personnel.teacher, ref Personnel.employee, classList);
            Teacher teacher_2 = new Teacher(ref Personnel.teacher, ref Personnel.employee, classList);
            Teacher teacher_3 = new Teacher(ref Personnel.teacher, ref Personnel.employee, classList);
            Teacher teacher_4 = new Teacher(ref Personnel.teacher, ref Personnel.employee, classList);
            Teacher teacher_5 = new Teacher(ref Personnel.teacher, ref Personnel.employee, classList);
            Console.WriteLine(Personnel.getTeacher());
            teacher_1.getTeacherAssignment();
            teacher_2.getTeacherAssignment();
            teacher_3.getTeacherAssignment();
            teacher_4.getTeacherAssignment();
            teacher_5.getTeacherAssignment();

            Console.WriteLine(Personnel.getJanitor());
            Janitor janitor_1 = new Janitor(ref Personnel.janitor, ref Personnel.employee);
            Janitor janitor_2 = new Janitor(ref Personnel.janitor, ref Personnel.employee);
            Janitor janitor_3 = new Janitor(ref Personnel.janitor, ref Personnel.employee);
            Janitor janitor_4 = new Janitor(ref Personnel.janitor, ref Personnel.employee);
            Janitor janitor_5 = new Janitor(ref Personnel.janitor, ref Personnel.employee);
            Console.WriteLine(Personnel.getJanitor());
            Console.WriteLine(Personnel.getEmployee());

            Console.WriteLine($"How many classes are offered here? There are {classList.Length}.");
            Console.WriteLine("The courses offered at this school are: ");
            Courses.getClasses(classList);


        }
        
        public static void setClasses(out Courses Math, out Courses Science, out Courses History, out Courses PE, out Courses[] classList)
        {
            Math = new Courses("Math", 8);
            Science = new Courses(studentCap: 10, name: "Science");
            History = new Courses("History", 10);
            PE = new Courses("PE", 10);

            classList = new Courses[] { Math, Science, History, PE };
        }
            
        
    }
}
