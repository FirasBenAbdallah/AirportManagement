﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public static class TestData
    {
        //Plane
        public static Plane planeB = new Plane
        {
            PlaneType = PlaneType.Boing,
            Capacity = 150,
            ManifactureDate = new DateTime(2015, 02, 03)
        };
        public static Plane planeA = new Plane
        {
            PlaneType = PlaneType.Airbus,
            Capacity = 250,
            ManifactureDate = new DateTime(2020, 11, 11)
        };

        //Staff
        public static Staff Staff1 = new Staff
        {
            FirstName = "captain",
            LastName = "captain",
            EmailAdress = "Captain.captain@gmail.com",
            BirthDate = new DateTime(1966,01,01),
            EmploymentDate = new DateTime(1999,01,01),
            Salary = 99999
        };
        public static Staff Staff2 = new Staff
        {
            FirstName = "hostess1",
            LastName = "hostess1",
            EmailAdress = "Hostess1.hostess1@gmail.com",
            BirthDate = new DateTime(1995, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };
        public static Staff Staff3 = new Staff
        {
            FirstName = "hostess2",
            LastName = "hostess2",
            EmailAdress = "Hostess2.hostess2@gmail.com",
            BirthDate = new DateTime(1996, 01, 01),
            EmploymentDate = new DateTime(2020, 01, 01),
            Salary = 999
        };

        //Traveller
        public static Traveller Traveller1 = new Traveller
        {
            FirstName = "Traveller1",
            LastName = "Traveller1",
            EmailAdress = "Traveller1.Traveller1@gmail.com",
            BirthDate = new DateTime(1980, 01, 01),
            HealthInformation = "No troubles",
            Nationality = "American"
        };
        public static Traveller Traveller2 = new Traveller
        {
            FirstName = "Traveller2",
            LastName = "Traveller2",
            EmailAdress = "Traveller2.Traveller2@gmail.com",
            BirthDate = new DateTime(1981, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "French"
        };
        public static Traveller Traveller3 = new Traveller
        {
            FirstName = "Traveller3",
            LastName = "Traveller3",
            EmailAdress = "Traveller3.Traveller3@gmail.com",
            BirthDate = new DateTime(1982, 01, 01),
            HealthInformation = "No troubles",
            Nationality = "Tinisian"
        };
        public static Traveller Traveller4 = new Traveller
        {
            FirstName = "Traveller4",
            LastName = "Traveller4",
            EmailAdress = "Traveller4.Traveller4@gmail.com",
            BirthDate = new DateTime(1983, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "American"
        };
        public static Traveller Traveller5 = new Traveller
        {
            FirstName = "Traveller5",
            LastName = "Traveller2",
            EmailAdress = "Traveller5.Traveller5@gmail.com",
            BirthDate = new DateTime(1984, 01, 01),
            HealthInformation = "Some troubles",
            Nationality = "Spanich"
        };

        //Flight
        public static Flight Flight1 = new Flight
        {
            FlightDate = new DateTime(2020, 01, 01, 15, 10, 10),
            Destination ="Paris",
            EffectiveArrival = new DateTime(2022, 01, 01, 17, 10, 10),
            MyPlane = planeA,
            EstimateDuration = 110,
            Passengers = new List<Passenger>
            {
                Traveller1,
                Traveller2,
                Traveller3,
                Traveller4,
                Traveller5
            }
        };
        public static Flight Flight2 = new Flight
        {
            FlightDate = new DateTime(2022, 02, 01, 21, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 02, 01, 23, 10, 10),
            MyPlane = planeB,
            EstimateDuration = 105
        };
        public static Flight Flight3 = new Flight
        {
            FlightDate = new DateTime(2022, 03, 01, 5, 10, 10),
            Destination = "Paris",
            EffectiveArrival = new DateTime(2022, 03, 01, 6, 40, 10),
            MyPlane = planeB,
            EstimateDuration = 100
        };
        public static Flight Flight4 = new Flight
        {
            FlightDate = new DateTime(2022, 04, 01, 6, 10, 10),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 04, 01, 8, 10, 10),
            MyPlane = planeB,
            EstimateDuration = 130
        };
        public static Flight Flight5 = new Flight
        {
            FlightDate = new DateTime(2022, 05, 01, 17, 10, 10),
            Destination = "Madrid",
            EffectiveArrival = new DateTime(2022, 03, 01, 18, 50, 10),
            MyPlane = planeB,
            EstimateDuration = 105
        };
        public static Flight Flight6 = new Flight
        {
            FlightDate = new DateTime(2022, 06, 01, 20, 10, 10),
            Destination = "Lisbonne",
            EffectiveArrival = new DateTime(2022, 06, 01, 22, 30, 10),
            MyPlane = planeA,
            EstimateDuration = 200
        };

        public static List<Flight> listFlights = new List<Flight>
        {
            Flight1,
            Flight2,
            Flight3,
            Flight4,
            Flight5,
            Flight6
        };

        
    }
}