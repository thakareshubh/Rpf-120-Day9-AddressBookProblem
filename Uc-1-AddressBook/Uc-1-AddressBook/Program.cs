using System;

namespace Uc_1_AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Person p1 = new Person();
            p1.Address();
            
        }
        class Person
        {
            
               
            public void Address()
            {
                Console.WriteLine("Enter your First name");
                string FirstName=Console.ReadLine();
                Console.WriteLine("Enter your last name");
                string LastName=Console.ReadLine();
                Console.WriteLine("Enter your State");
                string State=Console.ReadLine();
                Console.WriteLine("Enter your city");
                string City=Console.ReadLine();
                Console.WriteLine("Enter zip");
                string Zip =Console.ReadLine();
                Console.WriteLine("Enter phone number");
                string PhoneNumber=Console.ReadLine();
                Console.WriteLine("Enter your mail");
                string Email=Console.ReadLine();

            }

        }
    }
}
