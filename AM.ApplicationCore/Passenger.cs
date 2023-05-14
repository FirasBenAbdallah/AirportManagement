using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{
    public class Passenger
    {
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }
        public int PssportNumber { get; set; }
        public string? EmailAdress { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int TelNumber { get; set; }
        public override string ToString()
        {
            return "The passenger's name is : " + FirstName + " " + LastName;
        }
        //public bool CheckProfile(string firstname, string lastname) { 
        //    return FirstName == firstname && 
        //        LastName == lastname;
        //}
        //public bool CheckProfile1(string firstname, string lastname ,string email)
        //{
        //    return FirstName == firstname && 
        //        LastName == lastname && 
        //        EmailAdress == email;
        //}
        public ICollection<Flight>? Flights { get; set; }
        public bool CheckProfile(string firstname, string lastname, string? email=null)
        {
            if (email != null)
            {
                return FirstName == firstname &&
                LastName == lastname &&
                EmailAdress == email;
            }else
            {
                return FirstName == firstname &&
                LastName == lastname;
            }
            
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger");
        }
    }
}
