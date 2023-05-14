using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Flight
    {
        public string? Destination { get; set; }
        public string? Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimateDuration { get; set; }
        public Plane? MyPlane { get; set; }
        public string Airline { get; set; }
        public  ICollection<Passenger>? Passengers { get; set; }
        public override string ToString()
        {
            return "\n FlightDate : " + FlightDate + "\n Destination : " + Destination + "\n EffectiveArrival : " + EffectiveArrival 
                + "\n MyPlane : " + MyPlane + "\n EstimateDuration : " + EstimateDuration + "\n";
        }
    }
}
