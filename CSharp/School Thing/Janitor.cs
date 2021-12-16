using System;

namespace School
{
    class Janitor
    {
        // Fields
        private int id;

        // Constructor
        public Janitor(ref int janitor, ref int employee)
        {
            employee++;
            janitor++;
            this.id = janitor;
        }
    }
}
