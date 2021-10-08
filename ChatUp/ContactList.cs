using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class ContactList
    {
        public List<Person> MyContacts = new List<Person>(); // field
        // public List<Person> MyPersons { get; set; } = new List<Person>(); prop
        public void AddPersonToMyContactList(Person personToAdd) // ickestatic
        {
            this.MyContacts.Add(personToAdd);
        }


        public void ShowPersonFromMyContactList(Person personToShow)
        {
            
        }

        public void ChangePersonFromMyContactList(Person personToChange)
        {

        }

        public void DeletePersonFromMyContactList(Person personToDelete)
        {
            this.MyContacts.Remove(personToDelete);
        }

        public void ShowAllPersonsFromMyContactList(Person personsToShow)
        {

        }

        public void ShowPersonsWithCertainLetter(Person personsWithCertainLetter)
        {

        }


        //public List<Person> PersonList { get; set; }


        public ContactList() // default
        {

        }
        public ContactList(string firstnamne, string lastnamne) // parameterised
        {

        }

        // Namnregistret ska ha en metod kallad Menu() där en meny visas upp och användaren får välja vad denne vill göra
        public static void Menu() { }
    }
}
