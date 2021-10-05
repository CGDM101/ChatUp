using System;
using System.Collections.Generic;

namespace ChatUp
{
    class Program
    {
        List<Person> personList = new List<Person>();

        static void Main(string[] args)
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine("Vad vill du göra? Välj ett alternativ!\n1. Lägga till person\n2. Visa person\n3. Ändra person\n4. Ta bort person\n5a. Lista alla personer\n5b. Lista person vars namn börjar på viss bokstav");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddPerson();
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

        private static Person ListAllPersons() // should return list?
        {
            throw new NotImplementedException();
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

        private static Person AddPerson(Person p)
        {
            Console.Write("Skriv in personens förnamn: ");
            string f = Console.ReadLine();
            Console.Write("Skriv in personens efternamn: ");
            string l = Console.ReadLine();
            p.FirstName = f;
            p.LastName = l;

            List<Person> otherList = new List<Person>();
            otherList.Add(p);
            foreach (var item in otherList)
            {
                Console.WriteLine(p.FirstName);
            }
            return p; ;
        }
    }
}
