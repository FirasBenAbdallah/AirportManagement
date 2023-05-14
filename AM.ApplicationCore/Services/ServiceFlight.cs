using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System.Linq;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            if (Flights == null) return null;

           //List<DateTime> Dates = new List<DateTime>();

            IEnumerable<DateTime> flightsQuery =
                from flight in Flights
                where flight.Destination!.Equals(destination)
                select flight.FlightDate;
            
            return flightsQuery.ToList();
            /*
            for (int i = 0; i < Flights?.Count; i++)
            {
                if (Flights[i].Destination.Equals(destination))
                {
                    Dates.Add(Flights[i].FlightDate);
                }
            

            foreach (var flight in Flights)
            {
                if (flight.Destination.Equals(destination))
                {
                    Dates.Add(flight.FlightDate);
                }
            }*/
            //return Dates;
            
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    {
                        foreach (Flight f in Flights)
                        {
                            if (f.Destination.Equals(filterValue))
                                Console.WriteLine(f);
                        }
                    }
                    break;
                case "FlightDate":
                    {
                        foreach (Flight f in Flights)
                        {
                            if (f.FlightDate.Equals(DateTime.Parse(filterValue)))
                                Console.WriteLine(f);
                        }
                    }
                    break;
                case "Departure":
                    {
                        foreach (Flight f in Flights)
                        {
                            if (f.Departure.Equals(filterValue))
                                Console.WriteLine(f);
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        public void ShowFlightDetails(Plane plane){
            /*var flightsQuery =
                from flight in Flights
                where flight.MyPlane!.Equals(plane)
                select new { flight.FlightDate, flight.Destination};

            foreach (var info in flightsQuery){
                Console.WriteLine($"Flight date:{info.FlightDate}\nFlight destination: {info.Destination}");
            }*/
            var queryLambda = Flights!
                .Where(f => f.MyPlane!.Equals(plane))
                .Select(f => new { f.FlightDate, f.Destination });
            foreach (var info in queryLambda)
            {
                Console.WriteLine($"Flight date:{info.FlightDate}\nFlight destination: {info.Destination}");
            }
        }

        public int ProgrammedFlightNumber(DateTime startdate)
        {
            var fligh = 
                (
                     //from flight in Flights
                     //where flight.FlightDate.Equals(startdate) && (flight.FlightDate - startdate).TotalDays < 7
                     //select flight
                     Flights.Where (
                             flight => flight.FlightDate.Equals(startdate) && (flight.FlightDate - startdate).TotalDays < 7)
                            .Select (flight => flight)
                ).Count();

            return fligh;
        }

        public double? DurationAverage(string destination)
        {
            double? avg = (
                    //from flight in Flights
                    //where flight.Destination!.Equals(destination)
                    //select flight.EstimateDuration
                    Flights .Where (flight => flight.Destination!.Equals(destination))
                            .Select (flight => flight.EstimateDuration)
                ).Average();

            return avg;
        }

        public List<Flight> OrderedDurationFlights()
        {
            IEnumerable<Flight> q =
                //from flight in Flights
                //orderby flight.EstimateDuration
                //descending
                //select flight;
                Flights.OrderByDescending (flight => flight.EstimateDuration)
                       .Select (flight => flight);

            return q.ToList();
        }

        public List<Passenger> SeniorTravvellers(Flight flight)
        {
            IEnumerable<Passenger> q = (
                    //from passenger in flight.Passengers.OfType<Traveller>()
                    //orderby passenger.BirthDate
                    //select passenger
                    flight.Passengers.OfType<Traveller>()
                                     .OrderBy(passenger => passenger.BirthDate)
                                     .Select (passenger => passenger)
                ).Take(3);

            return q.ToList();
        }

        public void DestinationGroupedFlights()
        {
            var q =
                //from flight in Flights
                //group flight by flight.Destination;
                Flights.GroupBy(flight => flight.Destination);
            foreach (var g in q)
            {
                Console.WriteLine(g.Key);
                foreach (Flight f in g)
                {
                    Console.WriteLine($"Decollage: {f.FlightDate}");
                }
            }
        }

        public Action<Plane> FlightDetailsDel;
        public Func<string, double?> DurationAverageDel;

        public ServiceFlight()
        {
            //FlightDetailsDel = ShowFlightDetails;
            //DurationAverageDel = DurationAverage;
            FlightDetailsDel = (plane) => ShowFlightDetails(plane);
            DurationAverageDel = (dest) =>
            {
                double? avg = (
                //from flight in Flights
                //where flight.Destination!.Equals(dest)
                //select flight.EstimateDuration
                    Flights.Where (flight => flight.Destination!.Equals(dest))
                           .Select (flight => flight.EstimateDuration)
                ).Average();

                return avg;
            };
        }
        
        public override string ToString()
        {
            return "La liste " + TestData.Flight1 + TestData.Flight2 + TestData.Flight3 + TestData.Flight4 + TestData.Flight5 + TestData.Flight6;
        }
    }
}