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
                int Select = 0;
                Program details = new Program();
                switch (option)
                {
                    case 1:
                        Friends friend = new Friends();
                        do
                        {
                            Console.WriteLine("\n1:To Add a Office Contact");
                            Console.WriteLine("2:To View Office contact");
                            Console.WriteLine("3:To Edit Office Contacts");
                            Console.WriteLine("4:To Remove a Office contact");
                            Console.WriteLine("5: To search with city name");  
                            Console.WriteLine("6: To View with State Name");
                            Console.WriteLine("7: To count Person with City and State Name");
                            Console.WriteLine("8: To Sort by the Person Name");
                            Console.WriteLine("0:To Exit");

                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 0:
                                    Select = 1;
                                    break;
                                case 1:
                                    friend.AddingContacts();
                                    continue;
                                case 2:
                                    friend.DisplayContacts();
                                    continue;
                                case 3:
                                    friend.EditContact();
                                    continue;
                                case 4:
                                    friend.DeleteContact();
                                    continue;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string city = Console.ReadLine();
                                    friend.SearchPerson(city);
                                    continue;
                                case 6:
                                    Console.WriteLine("Enter state");
                                    string State = Console.ReadLine();
                                    friend.ViewByState(State);
                                    continue;
                                case 7:
                                    friend.Countperson();
                                    continue;
                                case 8:
                                    friend.SortByPersonName();
                                    continue;
                                default:
                                    Console.WriteLine("Enter a valid Input");
                                    break;
                            }
                            if (Select == 1) ;
                            break;
                        }
                        while (option != 0);
                        break;
                    case 2:
                        Office office = new Office();
                        do
                        {
                            Console.WriteLine("\n1:To Add a Office Contact");
                            Console.WriteLine("2:To View Office contact");
                            Console.WriteLine("3:To Edit Office Contacts");
                            Console.WriteLine("4:To Remove a Office contact");
                            Console.WriteLine("5: To search with city name");
                            Console.WriteLine("6: To View with State Name");
                            Console.WriteLine("7: To count Person with City and State Name");
                            Console.WriteLine("8: To Sort by the Person Name");
                            Console.WriteLine("0:To Exit");

                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 0:
                                    Select = 1;
                                    break;
                                case 1:
                                    office.AddingContacts();
                                    continue;
                                case 2:
                                    office.DisplayContacts();
                                    continue;
                                case 3:
                                    office.EditContact();
                                    continue;
                                case 4:
                                    office.DeleteContact();
                                    continue;
                                case 5:
                                    Console.WriteLine("Enter city");
                                    string City = Console.ReadLine();
                                    office.SearchPerson(City);
                                    continue;
                                case 6:
                                    Console.WriteLine("Enter state");
                                    string State = Console.ReadLine();
                                    office.ViewByState(State);
                                    continue;
                                case 7:
                                    office.Countperson();
                                    continue;
                                case 8:
                                    office.SortByPersonName();
                                    continue;
                                default:
                                    Console.WriteLine("Enter a valid Input");
                                    break;
                            }
                            if (Select == 1) ;
                            break;
                        }
                        while (option != 0);
                        break;
                }
            }
        }
    }
}

