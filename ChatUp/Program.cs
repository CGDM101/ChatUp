using System;
using System.Collections.Generic;

namespace ChatUp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ContactList minaKontakter = new ContactList(); // kontaktlistobjekt!!

            Person minKontakt = new Person();
            minKontakt.FirstName = "Nisse";
            minKontakt.LastName = "Karlsson";
            minKontakt.Alias = "nk";

            minaKontakter.AddPersonToMyContactList(minKontakt);

            
            
            List<Person> personList = new List<Person>(); // lista!!




            bool done = false;
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("Vad vill du göra? Välj ett alternativ!\n1. Lägga till person\n2. Visa person\n3. Ändra person\n4. Ta bort person\n5a. Lista alla personer\n5b. Lista person vars namn börjar på viss bokstav\nq. AVSLUTA");
                string userInput = Console.ReadLine().ToLower().Trim();
                switch (userInput)
                {
                    case "1": // LÄGGA TILL
                        Console.Write("Skriv in personens förnamn: "); 
                        string f = Console.ReadLine();
                        Console.Write("Skriv in personens efternamn: ");
                        string l = Console.ReadLine();
                        Console.Write("Skriv in personens alias: ");
                        string a = Console.ReadLine();
                        Person newPerson = new Person(f, l, a); // Konstruktorn körs
                        //newPerson.FirstName = f;
                        //newPerson.LastName = l;
                        minaKontakter.AddPersonToMyContactList(newPerson);
                        //personList.Add(newPerson);
                        Console.WriteLine(newPerson.Alias + " tillagd");
                        //AddPerson();
                        break;

                    case "2": // VISA ALLT OM PERSON
                        Console.WriteLine("Vilken av dessa vill du visa all information om? Välj förstabokstav");
                        string s = Console.ReadLine();
                        foreach (var item in personList)
                        {
                            if ((item.FirstName).Substring(0,1) == s)
                            {
                                Console.WriteLine(item.FirstName);
                                Console.WriteLine(item.LastName);
                                Console.WriteLine(item.Alias);
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }
                        //ShowPerson();
                        break;

                    case "3": // ÄNDRA PERSON
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

                    case "4": // TA BORT PERSON
                        Console.WriteLine("Vilken av dessa vill du ta bort? Välj förstabokstav på alias");
                        string sss = Console.ReadLine();

                        foreach (var item in minaKontakter.MyContacts)
                        {
                            if (item.Alias.Substring(0,1) == sss)
                            {
                                minaKontakter.DeletePersonFromMyContactList(item);
                                Console.WriteLine(item.Alias+" kommer att tas bort.");
                            }
                            Console.WriteLine("Fanns ingen med den begynnelsebokstaven."); // FIXA: Skrivs alltid ut
                        }
                        //DeletePerson();
                        break;

                    case "5a": // LISTA ALLA PERSONER
                        foreach (var item in personList)
                        {
                            Console.WriteLine("* " + item.FirstName); // Skriver ut förnamnet bara (alias?)
                        }
                        //ListAllPersons();
                        break;

                    case "5b": // LISTA PERSONER PÅ VISS BOKSTAV
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
                            // TODO Skrivs ut för alla inlagda personer som ej har rätt bokstav:
                            //else if (item.FirstName.Substring(0, 1) != ssss)
                            //{
                            //    Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            //}
                            // Annars fungerar det
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
    }
}
