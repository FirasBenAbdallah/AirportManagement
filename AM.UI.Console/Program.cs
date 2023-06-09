﻿// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using AM.INfrastructure;

/*Console.WriteLine("Hello, World!");

Plane Plane3 = new Plane
{
    Capacity = 200,
    ManifactureDate = new DateTime(2021, 10, 15)
};
Console.WriteLine(Plane3.ToString());
Passenger p1 = new Passenger
{
    FullName = new FullName ("Firas", "Ben Abdallah"),
    EmailAddress = "azerty.er@esprit.tn"
};
p1.PassengerType();
Console.WriteLine(p1.CheckProfile("Firas","Abdallah","az@esprit.tn"));
Staff s1 = new Staff
{
    FullName = new FullName ("Firas","Abdallah"),
};
s1.PassengerType();

Plane p3 = new Plane
{
    PlaneId = 3,
    Planetype = PlaneType.Airbus,
    Capacity = 200,
    ManifactureDate = DateTime.Now
};

Passenger pass = new Passenger
{
    FullName = new FullName("passenger1","passenger1"),
    BirthDate = new DateTime(1970, 1, 10),
    EmailAddress = "passenger1.passenger1@example.com",
    PssportNumber = "125465",
    TelNumber = "12345678"
};

ServiceFlight sf = new ServiceFlight();
sf.Flights = TestData.listFlights;

Console.WriteLine(sf.ToString());

Staff s = new Staff();

Traveller t = new();

Console.WriteLine(p3);

Console.WriteLine("-----------------\n");

pass.PassengerType();

Console.WriteLine();

s.PassengerType();

t.PassengerType();

Console.WriteLine("-----------------\n");

Console.WriteLine($"The profile of passanger {pass.FullName.FirstName} is: {(pass.CheckProfile("Passenger1", "Passenger1") ? "verified" : "unverified")}\n");

sf.Flights = TestData.listFlights;

String dest = "Paris";

Console.WriteLine($"Dates for {dest}:\n{string.Join("\n", sf.GetFlightDates(dest)!)}\n");

Console.WriteLine($"Flights for {dest}:");

sf.GetFlights("Destination", dest);

Console.WriteLine("-----------------\n");

sf.ShowFlightDetails(TestData.planeA);

Console.WriteLine("-----------------\n");

DateTime startDate = new DateTime(2020, 01, 30);

Console.WriteLine($"Number of flights dating 7 days after {startDate}: {sf.ProgrammedFlightNumber(startDate)}\n");

Console.WriteLine($"Average duration for the flights going to {dest} = {sf.DurationAverage(dest)}\n");

Console.WriteLine("-----------------\n");

sf.DestinationGroupedFlights();

Console.WriteLine("-----------------\n");

Console.WriteLine("Test delegues:\n");

sf.FlightDetailsDel(TestData.planeB);

Console.WriteLine($"[Del] Average duration for the flights going to {dest} = {sf.DurationAverageDel(dest)}");

Console.WriteLine("-----------------\n");

Console.WriteLine($"Before toUpper:\n{pass}");

pass.UpperFullName();

Console.WriteLine($"After toUpper:\n{pass}");*/
Plane plane1 = new Plane
{
    Planetype = PlaneType.Airbus,
    Capacity = 150,
    ManifactureDate = new DateTime(2015, 02, 03)
};

Flight f1 = new Flight()
{
    Departure = "Tunis",
    Airline = "Tunisair",
    FlightDate = new DateTime(2022, 02, 01, 21, 10, 10),
    Destination = "Paris",
    EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
    EstimateDuration = 103,
    MyPlane = plane1
};

AMContext contexte = new AMContext();

contexte.Flights.Add(f1);
contexte.SaveChanges();
Console.WriteLine(contexte.Flights.First().MyPlane.Capacity);


//Plane Plane1 = new Plane();
//Plane1.Capacity = 300;
//Plane1.ManifactureDate = new DateTime(2022, 09, 20);
//Console.WriteLine(Plane1.ToString());

//Plane Plane2 = new Plane(PlaneType.Boing, 500, DateTime.Now);
//Console.WriteLine(Plane2.ToString());