// See https://aka.ms/new-console-template for more information
namespace AddressBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("WelCome To The Address Book");
                Console.WriteLine("Select The Option For The Particular Address Book");
                Console.WriteLine("1 for the Friends.");
                Console.WriteLine("2 for the Office.");

                int option = Convert.ToInt32(Console.ReadLine());
                Program details = new Program();
                switch (option)
                {

                    case 1:

                        Friends friend = new Friends();

                        do
                        {
                            Console.WriteLine("\n1:To Add a Friends Contact");
                            Console.WriteLine("2:To Edit Friends Contacts");
                            Console.WriteLine("3:To Remove a Friends contact");
                            Console.WriteLine("4:To View Friends contact");
                            {
                                int option1 = Convert.ToInt32(Console.ReadLine());

                                {
                                    switch (option1)
                                    {

                                        case 1:
                                            friend.AddingContacts();
                                            continue;
                                        case 2:
                                            friend.EditContact();
                                            break;
                                        case 3:
                                            friend.DeleteContact();
                                            break;
                                        case 4:
                                            friend.FriendsView();
                                            break;
                                        default:
                                            Console.WriteLine("Enter a valid Input");
                                            break;
                                    }
                                    break;
                                }
                            }

                        }

                        while (option != 0);
                        break;

                    case 2:

                        Office office = new Office();

                        do
                        {
                            Console.WriteLine("\n1:To Add a Office Contact");
                            Console.WriteLine("2:To Edit Office Contacts");
                            Console.WriteLine("3:To Remove a Office contact");
                            Console.WriteLine("4:To View Office contact");
                            {
                                int option1 = Convert.ToInt32(Console.ReadLine());
                                {
                                    switch (option1)
                                    {

                                        case 1:
                                            office.AddingContacts();
                                            continue;
                                        case 2:
                                            office.EditContact();
                                            break;
                                        case 3:
                                            office.DeleteContact();
                                            break;
                                        case 4:
                                            office.OfficeView();
                                            break;
                                        default:
                                            Console.WriteLine("Enter a valid Input");
                                            break;
                                    }
                                    break;
                                }
                            }
                        }
                        while (option != 0);
                        break;
                }

            }
        }

    }

}

