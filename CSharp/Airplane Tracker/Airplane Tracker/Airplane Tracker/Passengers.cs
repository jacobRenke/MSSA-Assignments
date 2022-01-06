using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane_Tracker
{
    class Passengers
    {
        string passengerName;
        int passengerAge;
        int seatNumber;
        int flightNumber;

        public Passengers(int flightNumber, int numberOfSeats)
        {
            this.flightNumber = flightNumber;
            this.numberOfSeats = numberOfSeats;
        }
        
    }
}
