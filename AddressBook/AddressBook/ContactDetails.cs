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
        ArrayList contacts = new ArrayList();
        public void Contacts()
        {
            Console.WriteLine("Enter number of Contacts:");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Num; i++)
            {

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
                string Zip = Console.ReadLine();

                Console.WriteLine("Enter the phone number:");
                string PhoneNumber = Console.ReadLine();
                contacts.Add(FirstName);
                contacts.Add(LastName);
                contacts.Add(Address);
                contacts.Add(City);
                contacts.Add(State);
                contacts.Add(Email);
                contacts.Add(Zip);
                contacts.Add(PhoneNumber);

            }

            int j = 0;
            int count = 1;
            foreach (var item in contacts)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");

                    Console.WriteLine("Number of person :" + count);
                    Console.WriteLine("FirstName: " + contacts[j]);
                    Console.WriteLine("LastName: " + contacts[j + 1]);
                    Console.WriteLine("Address : " + contacts[j + 2]);
                    Console.WriteLine("City: " + contacts[j + 3]);
                    Console.WriteLine("State: " + contacts[j + 4]);
                    Console.WriteLine("Email: " + contacts[j + 5]);
                    Console.WriteLine("ZipCode: " + contacts[j + 6]);
                    Console.WriteLine("Phone Number: " + contacts[j + 7]);

                    count++;
                }
                j++;
            }

        }

        public void DeleteContact()
        {
            Console.WriteLine("Enter the name you want to remove");
            string Firstname = Console.ReadLine();
            for (int i = 0; i < contacts.Count; i += 8)
            {
                if (string.Equals(Firstname, (contacts[i])))
                {
                    contacts.RemoveAt(i);
                    contacts.RemoveAt(i);
                    contacts.RemoveAt(i);
                    contacts.RemoveAt(i);
                    contacts.RemoveAt(i);
                    contacts.RemoveAt(i);
                    contacts.RemoveAt(i);
                    contacts.RemoveAt(i);
                }
            }
            int j = 0;
            int count = 1;
            foreach (var item in contacts)
            {
                if (j % 8 == 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("After Editing the details are:");

                    Console.WriteLine("Number of person :" + count);
                    Console.WriteLine("FirstName: " + contacts[j]);
                    Console.WriteLine("LastName: " + contacts[j + 1]);
                    Console.WriteLine("Address : " + contacts[j + 2]);
                    Console.WriteLine("City: " + contacts[j + 3]);
                    Console.WriteLine("State: " + contacts[j + 4]);
                    Console.WriteLine("Email: " + contacts[j + 5]);
                    Console.WriteLine("ZipCode: " + contacts[j + 6]);
                    Console.WriteLine("Phone Number: " + contacts[j + 7]);
                    count++;
                }
                j++;

            }


        }
    }

}

