// See https://aka.ms/new-console-template for more information
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<ContactDetails> list = new List<ContactDetails>();
            ContactDetails contact = new ContactDetails();

            Console.WriteLine("Enter the First Name:");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name:");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Address:");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter the City:");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter the State:");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter the Zipcode:");
            contact.Zip = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the phone number:");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter the Email:");
            contact.Email = Console.ReadLine();


            list.Add(contact);

            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("FirstName: " + contact.FirstName);
            Console.WriteLine("LastName: " + contact.LastName);
            Console.WriteLine("Address: " + contact.Address);
            Console.WriteLine("City: " + contact.City);
            Console.WriteLine("State: " + contact.State);
            Console.WriteLine("ZipCode: " + contact.Zip);
            Console.WriteLine("Phone Number: " + contact.PhoneNumber);
            Console.WriteLine("Email: " + contact.Email);
        }

    }

}

