using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestListMaker
{
    class ListConstructor
    {
        public static string[] setGuestList()
        {
            Console.WriteLine("How many guests will be attending the party?");
            int guestCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter {0} guest's names: ", guestCount);

            string[] guestList = new string[guestCount];

            for (int i = 0; i < guestCount; i++)
            {
                guestList[i] = Console.ReadLine();
            }
            
            return guestList;
        }

        public static void getGuestList(string[] guestList)
        {
            Console.WriteLine("The following guests will be at the party.");
            for (int i = 0; i < guestList.Length; i++)
            {
                Console.WriteLine(guestList[i]);
            }
        }
    }
}
