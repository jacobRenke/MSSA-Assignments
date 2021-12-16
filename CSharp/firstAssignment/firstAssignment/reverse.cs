using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    class reverse
    {
        public static void runReverse()
        {
            Console.WriteLine("Please enter a value for 'a': ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a value for 'b': ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            temp = a; 
            a = b; 
            b = temp; 

            Console.WriteLine("{0} {1}", a, b);
            
        }
    }
}
