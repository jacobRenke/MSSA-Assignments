using System;

namespace genericCalc
{
    class Program<T>
    {
        static void Main(string[] args)
        {
            Calc calculator = new Calc();
            Console.WriteLine("Press 1 to use the addition function.");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Please enter two numbers into the calculator.");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());
                    calcAddition(a, b);
                    break;
            }
        }

        

        public static T calcAddition(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return x + y;
        }
    }
}
