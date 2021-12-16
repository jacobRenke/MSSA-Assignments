using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medicalApp
{
    public class Patient
    {
        double weightInput = Convert.ToDouble(Console.ReadLine());
    
        public double getWeightUSA(double weightInput)
        {
            return weightInput;
        }

        public double getWeightEU(double weightInput)
        {
            return weightInput * 0.45359237;
        }
    }
}
