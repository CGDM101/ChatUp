using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class ContactList
    {
        public List<Person> myContacts = new List<Person>(); // field
                                                             // public List<Person> MyPersons { get; set; } = new List<Person>(); prop

        /// <summary>
        /// Case 1
        /// </summary>
        /// <param name="personToAdd"></param>
        public void AddPersonToMyContactList(Person personToAdd)
        {
            this.myContacts.Add(personToAdd);
        }

        /// <summary>
        /// Case 2
        /// </summary>
        /// <param name="personToShow"></param>
        public void ShowPersonFromMyContactList(Person personToShow)
        {
            Console.WriteLine($"Förnamn: {personToShow.FirstName}");
            Console.WriteLine($"Efternamn: {personToShow.LastName}");
            Console.WriteLine($"Alias: {personToShow.Alias}");
        }

        /// <summary>
        /// Case 5a
        /// </summary>
        /// <param name="all"></param>
        public void ShowAllPersonsFromMyContactList(ContactList all)
        {
            Console.WriteLine("Här är en lista på alla alias:");
            foreach (var item in all.myContacts)
            {
                Console.WriteLine(item.Alias);
            }
        }

        /// <summary>
        /// Case 3
        /// </summary>
        /// <param name="personToBeChanged"></param>
        public void ChangePersonFromMyContactList(ContactList c)
        {
            Console.WriteLine("Vem vill du ändra? Välj begynnelsebokstav i alias!");
            string ans = Console.ReadLine().Trim().ToLower();
            foreach (var item in c.myContacts)
            {
                if ((item.Alias).Substring(0, 1) == ans)
                {
                    // Vad vill du ändra på denna?
                    Console.WriteLine("Vilken av egenskaperna vill du ändra?");
                    Console.WriteLine("[F]örnamn");
                    Console.WriteLine("[E]fternamn");
                    Console.WriteLine("[A]lias");
                    string input = Console.ReadLine().Trim().ToLower();
                    switch (input)
                    {
                        case "f":
                            Console.WriteLine("Du valde " + input + "( att ändra förnamn).");
                            Console.Write("Skriv in nytt förnamn: ");
                            item.FirstName = Console.ReadLine().Trim();
                            Console.WriteLine("Du har uppdaterat " + item.Alias + " med förnamnet " + item.FirstName + ". Personens fullständinga information är nu: Alias: " + item.Alias + " Förnamn: " + item.FirstName + " Efternamn: " + item.LastName + ".");
                            break;

                        case "e":
                            Console.WriteLine("Du valde " + input + "( att ändra efternamn).");
                            Console.Write("Skriv in nytt efternamn: ");
                            item.LastName = Console.ReadLine().Trim();
                            Console.WriteLine("Du har uppdaterat " + item.Alias + " med efternamnet " + item.LastName + ". Personens fullständinga information är nu: Alias: " + item.Alias + " Förnamn: " + item.FirstName + " Efternamn: " + item.LastName + ".");
                            break;

                        case "a":
                            Console.WriteLine("Du valde " + input + "( att ändra alias).");
                            Console.Write("Skriv in nytt alias: ");
                            item.Alias = Console.ReadLine().Trim();
                            Console.WriteLine("Du har uppdaterat " + item.Alias + " med aliaset " + item.Alias + ". Personens fullständinga information är nu: Alias: " + item.Alias + " Förnamn: " + item.FirstName + " Efternamn: " + item.LastName + ".");
                            break;

                        default:
                            Console.WriteLine("Ogiltigt val - försök igen!");
                            break;
                    }
                    break; // För att bryta loopen "vad vill du ändra?"
                }
            }
        }

        /// <summary>
        /// Case 5b
        /// </summary>
        /// <param name="c"></param>
        public void ShowPersonsWithCertainLetter(ContactList c)
        {
            Console.WriteLine("Lista alla på viss bokstav - Välj förstabokstav på alias!");
            string ans = Console.ReadLine().ToLower().Trim();
            foreach (var item in c.myContacts)
            {
                if ((item.Alias).Substring(0, 1) == ans)
                {
                    List<Person> certainList = new List<Person>();
                    certainList.Add(item);
                    foreach (var item2 in certainList)
                    {
                        Console.WriteLine($"Förnamn: {item2.FirstName}, Efternamn: {item2.LastName}, Alias: {item2.Alias}");
                    }
                }
            }
            Program.NoSuchPerson();
        }


        public ContactList() // default
        {

        }
    }
}
