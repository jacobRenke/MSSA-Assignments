using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    class average
    {
        public static void getAverage()
        {
            Random rnd = new Random();
            int num = rnd.Next(2, 6);
            Console.WriteLine("Please enter {0} integers: ", num);

            int[] val = new int[num];
            
            for (int i = 0; i < val.Length; i++)
            {
                val[i] = int.Parse(Console.ReadLine());
            }

            double average = Queryable.Average(val.AsQueryable());
            Console.WriteLine("The average of the list of integers is {0}.", average);

        }
    }
}
