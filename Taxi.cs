using System;

namespace taraa
{
    public class program
    {
        static void Main(string[] args)
        {
            Taxiku taxi = new Taxiku();

            taxi.drivername = "syarif";
            taxi.onduty = true;
            taxi.numpassenger = 10;

            taxi.taxiinfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();
        }
    }
}