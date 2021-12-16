using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    public class Calculator
    {
        int addition(int a, int b)
        {
            return a + b;
        }


        public void calcMoney()
        {
            float hourlyWage;
            float monthlyHours;
            float monthlyWage;
            string monthlyName;

            Console.WriteLine("Please enter employee name: ");
            monthlyName = Console.ReadLine();

            Console.WriteLine("Input how many hours they worked this month: ");
            monthlyHours = float.Parse(Console.ReadLine());

            Console.WriteLine("Input their hourly wage: ");
            hourlyWage = float.Parse(Console.ReadLine());

            monthlyWage = hourlyWage * monthlyHours;
            Console.WriteLine("{0}'s monthly wage is {1}.", monthlyName, monthlyWage);
        }
        public void calcGrade()
        {
            string studentName;
            int nameGrade;
            int passFail = 80;

            Console.WriteLine("Please enter the name of the student: ");
            studentName = Console.ReadLine();

            Console.WriteLine("Please enter {0}'s current grade Programming class.", studentName);
            nameGrade = Convert.ToInt32(Console.ReadLine());

            if (nameGrade >= passFail)
                Console.WriteLine("{0} has passed his stonkz.", studentName);
            else
                Console.WriteLine("{0} has failed his stonkz.", studentName);
        }
    }
}
