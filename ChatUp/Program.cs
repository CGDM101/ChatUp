using System;
using System.Collections.Generic;

namespace ChatUp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();

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
                        personList.Add(newPerson);

                        //AddPerson();
                        break;
                    case "2":
                        Console.WriteLine("Vilken av dessa vill du visa? Välj förstabokstav");
                        string s = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0,1) == s)
                            {
                                Console.WriteLine(item.FirstName);
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }
                        //ShowPerson();
                        break;
                    case "3":
                        Console.WriteLine("Vilken av dessa vill du ändra? Välj förstabokstav");
                        string ss = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0, 1) == ss)
                            {
                                Console.WriteLine("Vilken av egenskaperna vill du ändra?");
                                // ...
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }

                        //UpdatePerson();
                        break;
                    case "4":
                        Console.WriteLine("Vilken av dessa vill du ta bort? Välj förstabokstav");
                        string sss = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0, 1) == sss)
                            {
                                personList.Remove(item);
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }
                        //DeletePerson();
                        break;
                    case "5a":
                        foreach (var item in personList)
                        {
                            Console.WriteLine(item.FirstName);
                        }
                        //ListAllPersons();
                        break;
                    case "5b":
                        Console.WriteLine("Vilken av dessa vill du ta visa? Välj förstabokstav");
                        string ssss = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0, 1) == ssss)
                            {
                                Console.WriteLine(item.FirstName,item.LastName,item.InstagramProfile,item.IsBlocked,item.Alias);
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }
                        //ListCertainPerson();
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

        //public static ContactList ListAllPersons(ContactList c)
        //{
        //    foreach (var item in personList) // Hittar inte personList
        //    {
        //        Console.WriteLine(item.FirstName);
        //    }
        //    return c;
        //}

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
