using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    public class Teacher
    {
        public void teacherMulti()
        {
            int multiNum1;
            int multiNum2;

            Console.WriteLine("Please enter two separate numbers to multiply: ");
            multiNum1 = Convert.ToInt32(Console.ReadLine());
            multiNum2 = Convert.ToInt32(Console.ReadLine());

            if (multiNum1 == 0 || multiNum2 == 0)
                Console.WriteLine("The result is going to be 0.");
            else
                Console.WriteLine("The answer to the equation is " + (multiNum1 * multiNum2) + ". Thanks for asking.");
        }
        public void teacherDivision()
        {
            decimal divisionNum1;
            decimal divisionNum2;

            Console.WriteLine("Please enter two separate numbers to divide. Please include a decimal point: ");
            divisionNum1 = Convert.ToDecimal(Console.ReadLine());
            divisionNum2 = Convert.ToDecimal(Console.ReadLine());

            if (divisionNum1 == 0 || divisionNum2 == 0)
                Console.WriteLine("The result is going to be infinite. You will break math.");
            else
                Console.WriteLine("The answer to the equation is " + (divisionNum1 / divisionNum2) + ". Thanks for asking.");
        }

    }
}
