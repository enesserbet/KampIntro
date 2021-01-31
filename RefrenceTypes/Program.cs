using System;

namespace RefrenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 23;
            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayi1 : "+sayi1);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Ahmet";
            person2 = person1;

            person1.FirstName = "derin";
            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "salih";
            customer.CreditCardNumber = 321212;
            
            Employee employee = new Employee();

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);


            Console.WriteLine(((Customer)person3).CreditCardNumber);
        }
    }
    class Person
    {
        public string FirstName { get; set; }
        public int Id { get; set; }
        public string LastName { get; set; }
    }
    class Customer:Person
    {
        public int CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }
}
