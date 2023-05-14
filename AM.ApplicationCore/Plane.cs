using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore
{public enum PlaneType { Boing, Airbus}
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManifactureDate { get; set; }
        public int PlaneId { get; set; }
        public  PlaneType PlaneType { get; set; }
        public ICollection<Flight>? FlightsList { get; set; }
        public override string ToString()
        {
            return "The capacity is : " + Capacity + "The manifacture date is :" + ManifactureDate;
        }
        //public Plane()
        //{

        //}
        //public Plane(PlaneType pt, int capacity, DateTime date)
        //{
        //    PlaneType = pt;
        //    Capacity = capacity;
        //    ManifactureDate = date;
        //}
    }
}
