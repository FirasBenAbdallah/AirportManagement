// See https://aka.ms/new-console-template for more information

using AM.ApplicationCore;

Console.WriteLine("Hello, World!");
//Plane Plane1 = new Plane();
//Plane1.Capacity = 300;
//Plane1.ManifactureDate = new DateTime(2022, 09, 20);
//Console.WriteLine(Plane1.ToString());

//Plane Plane2 = new Plane(PlaneType.Boing, 500, DateTime.Now);
//Console.WriteLine(Plane2.ToString());

Plane Plane3 = new Plane
{
    Capacity = 200,
    ManifactureDate = new DateTime(2021, 10, 15)
};
Console.WriteLine(Plane3.ToString());
Passenger p1 = new Passenger
{
    FirstName = "Firas",
    LastName = "Abdallah",
    EmailAdress = "azerty.er@esprit.tn"
};
p1.PassengerType();
Console.WriteLine(p1.CheckProfile("Firas","Abdallah","az@esprit.tn"));
Staff s1 = new Staff
{
    FirstName = "Firas",
    LastName = "Abdallah",
};
s1.PassengerType();