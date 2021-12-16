using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    public class Math
    {
        public void findLarger()
        {
            double compareNum1;
            double compareNum2;

            Console.WriteLine("Please enter two values: ");
            compareNum1 = Convert.ToDouble(Console.ReadLine());
            compareNum2 = Convert.ToDouble(Console.ReadLine());

            if (compareNum1 > compareNum2)
                Console.WriteLine("{0} is the larger number.", compareNum1);
            else
                Console.WriteLine("{0} is the larger number.", compareNum2);
        }

        public void oddOrEven()
        {
            double oddevenNum1;

            Console.WriteLine("Please enter a number: ");
            oddevenNum1 = Convert.ToDouble(Console.ReadLine());

            double result = oddevenNum1 % 2;

            if (result == 0)
                Console.WriteLine("The number is even.");
            else
                Console.WriteLine("The number is odd.");
        }
    }
}
