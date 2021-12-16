using System;

namespace School
{
    class Employee
    {
        // Fields
        private int id;

        // Constructor
        public Employee(ref int employee)
        {
            employee++;
            this.id = employee;
        }
        
    }
}
