using System;
using System.Collections.Generic;

namespace ChatUp
{
    public class Program
    {
        // Hela namnregistret ska ha en egen klass (ex Contacts), den ska enbart instansieras från main()
        // Namnregistret ska ha en metod kallad Menu() där en meny visas upp och användaren får välja vad denne vill göra

        public static void Main(string[] args)
        {
            ContactList minaKontakter = new ContactList(); // kontaktlistobjekt - ej lista!


            Menu(minaKontakter); // Använder minaKontakter som argument när metoden körs




            Person minKontakt = new Person();
            minKontakt.FirstName = "Nisse";
            minKontakt.LastName = "Karlsson";
            minKontakt.Alias = "nk";

            minaKontakter.AddPersonToMyContactList(minKontakt);

            //PersonHelper.AskForPerson(minKontakt); // Print person etc
        }

        private static void Menu(ContactList minaKontakter) // hämtar in minaKontakter som parameter
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("Vad vill du göra? Välj ett alternativ!\n1. Lägga till person\n2. Visa person\n3. Ändra person\n4. Ta bort person\n5a. Lista alla personer\n5b. Lista person vars namn börjar på viss bokstav\nq. AVSLUTA");
                string userInput = Console.ReadLine().ToLower().Trim();
                switch (userInput)
                {
                    case "1": // LÄGGA TILL - FUNKAR
                        Console.Write("Skriv in personens förnamn: ");
                        string f = Console.ReadLine().Trim();
                        Console.Write("Skriv in personens efternamn: ");
                        string l = Console.ReadLine().Trim();
                        Console.Write("Skriv in personens alias: ");
                        string a = Console.ReadLine().Trim();
                        Person newPerson = new Person(f, l, a); // Konstruktorn körs
                        //newPerson.FirstName = f;
                        //newPerson.LastName = l;
                        
                        minaKontakter.AddPersonToMyContactList(newPerson);
                        Console.WriteLine(newPerson.Alias + " tillagd");
                        //AddPerson();
                        break;

                    case "2": // VISA ALLT OM PERSON - FUNKAR
                        Console.WriteLine("Vilken av dessa vill du visa all information om? Välj förstabokstav i alias!");
                        string s = Console.ReadLine().ToLower().Trim();

                        foreach (var item in minaKontakter.MyContacts)
                        {
                            if ((item.Alias).Substring(0, 1) == s)
                            {
                                //Console.WriteLine(item.FirstName);
                                //Console.WriteLine(item.LastName);
                                //Console.WriteLine(item.Alias);
                                minaKontakter.ShowPersonFromMyContactList(item); // kallar på metoden
                            }
                            else
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                            }
                        }
                        break;

                    case "3": // ÄNDRA PERSON -Funkar förutom vid else


                        Console.WriteLine("Vilken av dessa vill du ändra? Välj förstabokstav på alias!");
                        string ss = Console.ReadLine().ToLower().Trim();
                        foreach (var item in minaKontakter.MyContacts)
                        {
                            if ((item.Alias).Substring(0, 1) == ss)
                            {
                                Console.WriteLine("Vilken av egenskaperna vill du ändra?");
                                Console.WriteLine("[F]örnamn");
                                Console.WriteLine("[E]fternamn");
                                Console.WriteLine("[A]lias");
                                //Console.WriteLine("[E]mejl-adress");
                                //Console.WriteLine("[F]acebookprofil");
                                //Console.WriteLine("[I]nstagramprofil");
                                //Console.WriteLine("[B]lockerad");
                                //Console.WriteLine("[G]hostad");
                                //Console.WriteLine("[L]inkedInProfil");
                                //Console.WriteLine("[T]witterprofil");
                                string input = Console.ReadLine().Trim().ToLower();
                                switch (input)
                                {
                                    case "f":
                                        Console.WriteLine("Du valde " + input);
                                        Console.Write("Skriv in nytt förnamn: ");
                                        f = Console.ReadLine().Trim();
                                        item.FirstName = f;
                                        Console.WriteLine("Du har uppdaterat " + item.Alias + " med förnamnet: " + f + ". Personens fullständiga information är nu: " + item.Alias + " " + item.FirstName + " " + item.LastName);
                                        break;
                                    case "e":
                                        Console.WriteLine("Du valde " + input);
                                        Console.Write("Skriv in nytt efternamn: ");
                                        l = Console.ReadLine().Trim();
                                        item.LastName = l;
                                        Console.WriteLine("Du har uppdaterat " + item.Alias + " med efternamn: " + l + ". Personens fullständiga information är nu: " + item.Alias + " " + item.FirstName + " " + item.LastName);
                                        break;
                                    case "a":
                                        Console.WriteLine("Du valde " + input);
                                        Console.Write("Skriv in nytt alias: ");
                                        a = Console.ReadLine().Trim();
                                        item.Alias = a;
                                        Console.WriteLine("Du har uppdaterat " + item.Alias + " med aliaset: " + a + ". Personens fullständiga information är nu: " + item.Alias + " " + item.FirstName + " " + item.LastName);
                                        break;

                                    default:
                                        Console.WriteLine("Ogitligt val - försök igen!");
                                        break;
                                }
                            }
                            else // lägga till if?
                            {
                                Console.WriteLine("Fanns ingen med den begynnelsebokstaven."); // Funkar delvis - ej efter ändring
                            }
                        }
                        //UpdatePerson();
                        break;

                    case "4": // TA BORT PERSON - funkar
                        Console.WriteLine("Vilken av dessa vill du ta bort? Välj förstabokstav på alias");
                        string sss = Console.ReadLine().ToLower().Trim();

                        Person removedPerson = new Person();
                        foreach (var item in minaKontakter.MyContacts)
                        {
                            if (item.Alias.Substring(0, 1) == sss)
                            {
                                removedPerson = item;
                                //minaKontakter.MyContacts.Remove(item);
                                //minaKontakter.DeletePersonFromMyContactList(item); // om använder metod istället
                                Console.WriteLine(item.Alias + " kommer att tas bort.");
                            }
                            else if(item.Alias.Substring(0, 1) == sss)
                            Console.WriteLine("Fanns ingen med den begynnelsebokstaven.");
                        }
                        minaKontakter.MyContacts.Remove(removedPerson); // måste ha här pga exception annars

                        //DeletePerson();
                        break;

                    case "5a": // LISTA ALLA PERSONER - varkar ufnka
                        //foreach (var item in minaKontakter.MyContacts)
                        //{
                        //    Console.WriteLine("* " + item.Alias);
                        //}
                        //ListAllPersons();
                        minaKontakter.ShowAllPersonsFromMyContactList(minaKontakter);

                        break;

                    case "5b": // LISTA PERSONER PÅ VISS BOKSTAV - FUNKAR förutom else
                        Console.WriteLine("Lista alla på viss bokstav - Välj förstabokstav");
                        string ssss = Console.ReadLine().ToLower().Trim();
                        foreach (var item in minaKontakter.MyContacts)
                        {
                            if ((item.FirstName).Substring(0, 1) == ssss)
                            {
                                List<Person> specialList = new List<Person>();
                                specialList.Add(item);
                                foreach (var itemm in specialList)
                                {
                                    Console.WriteLine($"Förnamn: {itemm.FirstName}, Efternamn: {itemm.LastName}, Alias: {itemm.Alias}");
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
