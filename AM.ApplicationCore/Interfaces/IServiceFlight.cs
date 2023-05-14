namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startdate);
        double? DurationAverage(string destination);
        List<Flight> OrderedDurationFlights();
        List<Passenger> SeniorTravvellers(Flight flight);
        void DestinationGroupedFlights();
    }

}
