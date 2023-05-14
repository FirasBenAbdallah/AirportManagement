using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }

        [DisplayName("Date of birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Key,StringLength(7)]
        public string? PssportNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        [MinLength(3,ErrorMessage = "Longueur min est 3")
            , MaxLength(25, ErrorMessage = "Longueur max est 25")]
        public FullName FullName { get; set; }

        [RegularExpression(@"^[0-9]{8}$")]
        public string TelNumber { get; set; }
        public override string ToString()
        {
            return "The passenger's name is : " + FullName.FirstName + " " + FullName.LastName;
        }
      
        //public ICollection<Flight>? Flights { get; set; }
        public virtual ICollection<Ticket>? Tickets { get; set; }
        public bool CheckProfile(string firstname, string lastname, string? email=null)
        {
            if (email != null)
            {
                return FullName.FirstName == firstname &&
                FullName.LastName == lastname &&
                EmailAddress == email;
            }else
            {
                return FullName.FirstName == firstname &&
                FullName.LastName == lastname;
            }
            
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("I'm a passenger");
        }
    }
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


//public string? FirstName { get; set; }
//public string? LastName { get; set; }
