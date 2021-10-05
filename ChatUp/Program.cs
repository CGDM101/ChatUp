using System;
using System.Collections.Generic;

namespace ChatUp
{
    class Program
    {
        /*
         NAMNLISTA DÄR MAN KAN:
Lägga till namn
Ta bort namn
Ändra namn
Söka upp namn
Visa lista på alla namn
         */
        static void Main(string[] args)
        {
            // Namnlista:
            List<Person> personList = new List<Person>();

            // Lägga till namn:
            Person first = new Person { FirstName = "hello", LastName = "world" };;
            personList.Add(first);

            // Ändra namn:
            first.FirstName = "nytt förnamn";

            // Ta bort namn:
            personList.Add(new Person { FirstName = "ANother", LastName = "one" });
            personList.Add(new Person { FirstName = "yet", LastName = "another one" });

            personList.RemoveAt(0);

            // Söka upp namn:
            foreach (var item in personList)
            {
                if (item.FirstName == "yet")
                {
                    Console.WriteLine("Du har funnit " + item.FirstName);
                }
            }
        }
    }
}
