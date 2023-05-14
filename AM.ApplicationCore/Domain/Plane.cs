using System.ComponentModel.DataAnnotations;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        [Range(0,int.MaxValue)]//entier positif 
        public int Capacity { get; set; }
        public DateTime ManifactureDate { get; set; }
        public int PlaneId { get; set; }
        public  PlaneType Planetype { get; set; }
        public ICollection<Flight>? FlightsList { get; set; }
        public override string ToString()
        {
            return "The capacity is : " + Capacity + "The manifacture date is :" + ManifactureDate;
        }
    }
}
