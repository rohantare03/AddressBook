using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Contacts
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string City;
        public string State;
        public string Email;
        public int Zip;
        public long PhoneNumber;       
        public Contacts(string FirstName, string LastName, string Address, string City, string State, string Email, int Zip, long PhoneNumber )
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.Zip = Zip;
            this.PhoneNumber = PhoneNumber;          
        }
    }
}
