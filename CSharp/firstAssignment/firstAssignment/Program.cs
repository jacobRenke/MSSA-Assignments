using System;

namespace firstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Hello. Please press enter to continue to the menu.");
                Console.ReadKey();
                Console.WriteLine("Option 1: Calculate how much money an employee makes per month.");
                Console.WriteLine("Option 2: Find out if a selected student has passed or failed their Programming class.");
                Console.WriteLine("Option 3: Multiply two values together.");
                Console.WriteLine("Option 4: Divide two values togther. Don't use 0. Trust me.");
                Console.WriteLine("Option 5: Find the larger of two values.");
                Console.WriteLine("Option 6: Determine if a number is odd or even.");
                Console.WriteLine("Option 7: The Game Selector!");
                Console.WriteLine("Option 8: Find the cube of a number: ");
                Console.WriteLine("Option 12: Exit.");
                int option = int.Parse(Console.ReadLine());

                Calculator calculator = new Calculator();
                Teacher calcTeacher = new Teacher();
                Math math = new Math();
                ExtraFunction xtraFunc = new ExtraFunction();
                switch (option)
                {
                    case 1:
                        calculator.calcMoney();
                        Console.ReadKey();
                        break;
                    case 2:
                        calculator.calcGrade();
                        Console.ReadKey();
                        break;
                    case 3:
                        calcTeacher.teacherMulti();
                        Console.ReadKey();
                        break;
                    case 4:
                        calcTeacher.teacherDivision();
                        Console.ReadKey();
                        break;
                    case 5:
                        math.findLarger();
                        Console.ReadKey();
                        break;
                    case 6:
                        math.oddOrEven();
                        Console.ReadKey();
                        break;
                    case 7:
                        xtraFunc.extraGameSelector();
                        Console.ReadKey();
                        break;
                    case 8:
                        cubeOfNum.getCubeOfNum();
                        Console.ReadKey();
                        break;
                    case 9:
                        average.getAverage();
                        Console.ReadKey();
                        break;
                    case 10:
                        multiplicationTable.getMultiTable();
                        Console.ReadKey();
                        break;
                    case 11:
                        break;
                    case 12:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a value from 1 - 12.");
                        break;
                }
            }
            while (flag);
        }
       
    }
}
