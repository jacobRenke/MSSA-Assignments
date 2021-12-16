using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Courses
    {
        private string name;
        private int studentCap;

        public Courses(string name, int studentCap)
        {
            this.name = name;
            this.studentCap = studentCap;
    }
         

        public static void getClasses(Courses[] classList)
        {
            for (int i = 0; i < classList.Length; i++)
            {
                Console.WriteLine(classList[i].name);
            }
        }

        public string getClassName()
        {
            return this.name;
        }
    }
}
