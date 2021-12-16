using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    class multiplicationTable
    {
        public static void getMultiTable()
        {
            Console.WriteLine("Please enter a number to print it's multiplication table: ");

            int j, n;
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The multiplication table is as follows: ");

            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                for (int l = 1; l <= n; l++)
                {
                    Console.Write("" + (l * j) + "\t");
                }
                Console.WriteLine();
            }
            
        }
    }
    
}
