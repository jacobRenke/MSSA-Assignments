using System;

namespace GuestListMaker
{
    class GuestList
    {
        static void Main(string[] args)
        {
            string[] list = ListConstructor.setGuestList();
            ListConstructor.getGuestList(list);
        }
    }
}
