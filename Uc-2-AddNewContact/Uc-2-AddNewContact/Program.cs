using System;
using System.Collections.Generic;
using System.Linq;

namespace Uc_2_AddNewContact
{
    internal class Program
    {
        private int numOfPeople;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.AddPerson(4);
        }
        private void AddPerson(int numOfPeoPle )
        {
            List<Person> people = new List<Person>();

           
            while (numOfPeople < 4)
            {
                Person person = new Person();
                Console.WriteLine("Enter new name");
                person.Name = Console.ReadLine();
                Console.WriteLine("Enter your address");
                person.Address = Console.ReadLine();

                people.Add(person);
                numOfPeople++;
            }
        }
    }
    public class Person 
    {
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
