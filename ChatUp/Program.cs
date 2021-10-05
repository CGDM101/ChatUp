using System;
using System.Collections.Generic;

namespace ChatUp
{
    public class Program
    {
        public List<Person> personList = new List<Person>();

        public static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Vad vill du göra? Välj ett alternativ!\n1. Lägga till person\n2. Visa person\n3. Ändra person\n4. Ta bort person\n5a. Lista alla personer\n5b. Lista person vars namn börjar på viss bokstav");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.Write("Skriv in personens förnamn: ");
                        string f = Console.ReadLine();
                        Console.Write("Skriv in personens efternamn: ");
                        string l = Console.ReadLine();
                        Person newPerson = new Person();
                        newPerson.FirstName = f;
                        newPerson.LastName = l;
                        
                        //AddPerson();
                        break;
                    case "2":
                        ShowPerson();
                        break;
                    case "3":
                        UpdatePerson();
                        break;
                    case "4":
                        DeletePerson();
                        break;
                    case "5a":
                        ListAllPersons();
                        break;
                    case "5b":
                        ListCertainPerson();
                        break;
                    default:
                        Console.WriteLine("Ogitligt val. Försök igen!");
                        break;
                }
            }          
        }

        private static Person ListCertainPerson()
        {
            throw new NotImplementedException();
        }

        public static ContactList ListAllPersons(ContactList c)
        {
            foreach (var item in personList) // Hittar inte personList
            {
                Console.WriteLine(item.FirstName);
            }
            return c;
        }

        private static Person DeletePerson()
        {
            throw new NotImplementedException();
        }

        private static Person UpdatePerson()
        {
            throw new NotImplementedException();
        }

        private static Person ShowPerson()
        {
            throw new NotImplementedException();
        }

        private static void AddPerson()
        {
            throw new NotImplementedException();
        }
    }
}
