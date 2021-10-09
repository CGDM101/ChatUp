using System;
using System.Collections.Generic;
using System.Text;
 
namespace ChatUp
{
    public static class PersonHelper
    {
        public static Person AskForPerson(ContactList c)
        {
            Console.WriteLine("Vilken av dessa vill du visa all information om? Välj förstabokstav i alias!");
            string s = Console.ReadLine();

            Person personChosen = new Person();

            foreach (var item in c.MyContacts)
            {
                if (item.Alias == s)
                {
                    personChosen = item;
                }
            }
            return personChosen;
        }
    }
}
