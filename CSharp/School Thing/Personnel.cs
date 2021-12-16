using System;

namespace School
{
    class Personnel
    {
        public static int students = 0;
        public static int employee = 0;
        public static int janitor = 0;
        public static int teacher = 0;

        // Constructor
        // public School () {
        //     students = 0;
        // }

        // Method
        public static int getStudents() {
            return students;
        }

        public static int getEmployee()
        {
            return employee;
        }

        public static int getJanitor()
        {
            return janitor;
        }
        
        public static int getTeacher()
        {
            return teacher;
        }
        
    }
}
