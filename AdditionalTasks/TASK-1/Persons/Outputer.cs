using System;

namespace Persons
{
    class Outputer
    {
        const string PRINTPERSONSNAME = "\nPerson's name: ";
        const string PRINTPERSONSAGE = "Person's age: ";

        public void PrintListOfPeople(Person[] person)
        {
            Console.Clear();
            foreach (Person man in person)
            {
                Console.WriteLine(PRINTPERSONSNAME + man.Name);
                Console.WriteLine(PRINTPERSONSAGE + man.Age);
            }
        }
    }
}