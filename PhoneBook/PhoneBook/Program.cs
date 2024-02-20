using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int id = rand.Next(100, 200);
            PhoneBook phoneBook = new PhoneBook();
            int output;
            Console.WriteLine(">To add contact type 1\n>To delete contact type 2\n>To search contact type 3\n>To show all contacts type 4\n>To exit type 5");
            output = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                switch (output)
                {
                    case 1:
                        {
                            Console.WriteLine("Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Number:");
                            long number = Convert.ToInt64(Console.ReadLine());
                            Contact newContact = new Contact(name, number, id);
                            phoneBook.Add(newContact);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Name:");
                            string name = Console.ReadLine();
                            phoneBook.Delete(name);
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Name:");
                            string contactName = Console.ReadLine();
                            phoneBook.ShowByName(contactName);
                        }
                        break;
                    case 4:
                        phoneBook.ShowAll();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("Next operation?");
                output = Convert.ToInt32(Console.ReadLine());
            }
 
        }
    }
}
