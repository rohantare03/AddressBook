// See https://aka.ms/new-console-template for more information
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContactDetails contactDetail = new ContactDetails();
            contactDetail.Contacts();
            contactDetail.DeleteContact();
        }

    }

}

