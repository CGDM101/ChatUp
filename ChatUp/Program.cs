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
                Console.WriteLine();
                Console.WriteLine("Vad vill du göra? Välj ett alternativ!\n1. Lägga till person\n2. Visa person\n3. Ändra person\n4. Ta bort person\n5a. Lista alla personer\n5b. Lista person vars namn börjar på viss bokstav\nq. AVSLUTA");
                string userInput = Console.ReadLine().ToLower().Trim();
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
                        Console.WriteLine(newPerson.FirstName + " tillagd");
                        //foreach (var item in personList)
                        //{
                        //    Console.WriteLine(item.FirstName);
                        //}
                        //AddPerson();
                        break;
                    case "2":
                        Console.WriteLine("Vilken av dessa vill du visa all information om? Välj förstabokstav");
                        string s = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0,1) == s)
                            {
                                Console.WriteLine(item.FirstName); // ska komma från ctor
                                Console.WriteLine(item.LastName);
                                Console.WriteLine(item.Alias); // null
                                Console.WriteLine(item.EmailAddress);
                                Console.WriteLine(item.FacebookProfile);
                                Console.WriteLine(item.InstagramProfile);
                                Console.WriteLine(item.IsBlocked); 
                                Console.WriteLine(item.IsGhosted);
                                Console.WriteLine(item.LinkedinProfile);
                                Console.WriteLine(item.TwitterProfile);
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }
                        //ShowPerson();
                        break;
                    case "3": // Ändra person
                        Console.WriteLine("Vilken av dessa vill du ändra? Välj förstabokstav");
                        string ss = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0, 1) == ss)
                            {
                                Console.WriteLine("Vilken av egenskaperna vill du ändra?");
                                Console.WriteLine("[F]örnamn");
                                Console.WriteLine("[E]fternamn");
                                Console.WriteLine("[A]lias");
                                Console.WriteLine("[E]mejl-adress");
                                Console.WriteLine("[F]acebookprofil");
                                Console.WriteLine("[I]nstagramprofil");
                                Console.WriteLine("[B]lockerad");
                                Console.WriteLine("[G]hostad");
                                Console.WriteLine("[L]inkedInProfil");
                                Console.WriteLine("[T]witterprofil");
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
                        foreach (var item in personList) // Invalid Operation Exception
                        {
                            if ((item.FirstName).Substring(0, 1) == sss)
                            {
                                //personList.Remove(item);
                                Console.WriteLine(item.FirstName + " kommer att tas bort");
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                            personList.Remove(item);
                        }

                        //DeletePerson();
                        break;
                    case "5a":
                        //Person a = new Person() { FirstName = "Adam" };
                        //Person b = new Person() { FirstName = "Bertil" }; Person c = new Person() { FirstName = "Caesar" }; Person d = new Person() { FirstName = "David" }; Person e = new Person() { FirstName = "Erik" };
                        //personList.Add(a); personList.Add(b); personList.Add(c); personList.Add(d); personList.Add(e);
                        foreach (var item in personList)
                        {
                            Console.WriteLine(item.FirstName);
                        }
                        //ListAllPersons();
                        break;
                    case "5b":
                        Console.WriteLine("Lista alla på viss bokstav - Välj förstabokstav");
                        string ssss = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0, 1) == ssss)
                            {
                                List<Person> specialList = new List<Person>();
                                specialList.Add(item);
                                foreach (var itemm in specialList)
                                {
                                    Console.WriteLine(itemm.FirstName);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }
                        //ListCertainPerson();
                        break;
                    case "q":
                        done = true;
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
