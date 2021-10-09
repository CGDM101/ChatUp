using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class ContactList
    {
        public List<Person> MyContacts = new List<Person>(); // field
       // public List<Person> MyPersons { get; set; } = new List<Person>(); prop

        public void AddPersonToMyContactList(Person personToAdd) // ickestatic. FUNKAR
        {
            this.MyContacts.Add(personToAdd);
        }

        //public void DeletePersonFromMyContactList(Person personToDelete)
        //{
        //    this.MyContacts.Remove(personToDelete);
        //}

        public void ShowPersonFromMyContactList(Person personToShow) // Verkar funka
        {
            Console.WriteLine(personToShow.FirstName);
            Console.WriteLine(personToShow.LastName);
            Console.WriteLine(personToShow.Alias);
        }

        public void ChangePersonFromMyContactList()
        {
            
        }


        public void ShowAllPersonsFromMyContactList(ContactList all) // verkar funka
        {
            foreach (var item in all.MyContacts)
            {
                Console.WriteLine(item.Alias);
            }
        }

        public void ShowPersonsWithCertainLetter(Person personsWithCertainLetter)
        {

        }

        public ContactList() // default
        {

        }
        public ContactList(string firstnamne, string lastnamne) // parameterised
        {

        }

    }
}
