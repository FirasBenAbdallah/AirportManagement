using System.ComponentModel.DataAnnotations;


namespace AM.ApplicationCore.Domain
{
    public class Staff : Passenger
    {
        public DateTime EmploymentDate { get; set; }
        public string? Function { get; set; }
        [DataType(DataType.Currency)]
        public int Salary { get; set; }
        public override void PassengerType()
        {
            base.PassengerType();
            Console.WriteLine("I'm a staff member");
        }
    }
}
