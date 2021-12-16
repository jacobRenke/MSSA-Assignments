using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstAssignment
{
    class cubeOfNum
    {
        public static void getCubeOfNum()
        {
            Console.WriteLine("Please enter a number to be cubed: ");
            float cubeNumInput = float.Parse(Console.ReadLine());

            float cubeNumFinal = cubeNumInput * cubeNumInput * cubeNumInput;
            Console.WriteLine("The cube of {0} is {1}.", cubeNumInput, cubeNumFinal);
        }
    }
}
