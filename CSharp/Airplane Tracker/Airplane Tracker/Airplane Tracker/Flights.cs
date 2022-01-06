using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane_Tracker
{
    public class Flights
    {
        int flightNumber;
        int numberOfSeats;

        public Flights(int flightNumber, int numberOfSeats)
        {
            this.flightNumber = flightNumber;
            this.numberOfSeats = numberOfSeats;
        }
    }
}
