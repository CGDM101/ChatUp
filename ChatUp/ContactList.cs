using System;
using System.Collections.Generic;
using System.Text;

namespace ChatUp
{
    public class ContactList
    {
        public List<Person> myContacts = new List<Person>(); // field
       // public List<Person> MyPersons { get; set; } = new List<Person>(); prop

        public void AddPersonToMyContactList(Person personToAdd)
        {
            this.myContacts.Add(personToAdd);
        }

        public void ShowPersonFromMyContactList(Person personToShow)
        {
            Console.WriteLine(personToShow.FirstName);
            Console.WriteLine(personToShow.LastName);
            Console.WriteLine(personToShow.Alias);
        }

        public void ChangePersonFromMyContactList()
        {
            
        }


        public void ShowAllPersonsFromMyContactList(ContactList all)
        {
            Console.WriteLine("Här är en lista på alla alias:");
            foreach (var item in all.myContacts)
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
        //public ContactList(string alias, string firstnamne, string lastnamne) // parameterised
        //{
        //    Person a = new Person() { Alias = "a", FirstName = "aaa", LastName = "ööö" };
        //    Person b = new Person() { Alias = "b", FirstName = "bbb", LastName = "äää" };
        //    Person c = new Person() { Alias = "c", FirstName = "ccc", LastName = "ååå" };
        //    List<Person> testList = new List<Person>();
        //    testList.Add(a);testList.Add(b);testList.Add(c);
        //}

    }
}
