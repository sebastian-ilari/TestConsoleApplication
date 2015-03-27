
namespace TestConsoleApplication.PolymorphicEmployee
{
    public class EmployeeRecord
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public EmployeeType Type { get; set; }
        
        public decimal PaymentPerHour { get; set; }
    }
}
