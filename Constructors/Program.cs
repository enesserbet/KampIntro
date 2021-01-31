using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(Id = 1, FirstName = "Talha", 
                LastName = "ŞErbet", City = "istanbul");
            Customer customer = new Customer(2, "derin", "Demiroğ", "ankara");


        }

        
    }
    class Customer
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
 