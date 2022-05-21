using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class ContactDetails
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public int Zip;
        public long PhoneNumber;
        public string Email;

        public void AddContacts() 
        {
            Console.WriteLine("Enter number of Contacts:");
            int Num = Convert.ToInt32(Console.ReadLine());
            ArrayList contact = new ArrayList();

            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("\nAdd Details of the person: " + i);

                Console.WriteLine("Enter the First Name:");
                string FirstName = Console.ReadLine();

                Console.WriteLine("Enter the Last Name:");
                string LastName = Console.ReadLine();

                Console.WriteLine("Enter the Address:");
                string Address = Console.ReadLine();

                Console.WriteLine("Enter the City:");
                string City = Console.ReadLine();

                Console.WriteLine("Enter the State:");
                string State = Console.ReadLine();

                Console.WriteLine("Enter the Email:");
                string Email = Console.ReadLine();

                Console.WriteLine("Enter the Zipcode:");
                int Zip = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the phone number:");
                long PhoneNumber = Convert.ToInt64(Console.ReadLine());

                contact.Add(FirstName);
                contact.Add(LastName);
                contact.Add(Address);
                contact.Add(City);
                contact.Add(State);
                contact.Add(Email);
                contact.Add(Zip);
                contact.Add(PhoneNumber);


            }

            int j = 0;
            int count = 1;
            foreach (var item in contact)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    Console.WriteLine("\nNumber of person :" + count);
                    Console.WriteLine("FirstName: " + contact[j]);
                    Console.WriteLine("LastName: " + contact[j + 1]);
                    Console.WriteLine("Address : " + contact[j + 2]);
                    Console.WriteLine("City: " + contact[j + 3]);
                    Console.WriteLine("State: " + contact[j + 4]);
                    Console.WriteLine("Email: " + contact[j + 5]);
                    Console.WriteLine("ZipCode: " + contact[j + 6]);
                    Console.WriteLine("Phone Number: " + contact[j + 7]);
                    count++;
                }
                j++;
            }



        }
    }

}

