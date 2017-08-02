using System;

namespace Persons
{
    class Outputer
    {
        public void PrintListOfPeople(Person[] persons)
        {
            Console.Clear();
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(String.Format("\nPerson №{0} : ", i + 1) + persons[i].ToString());
            }
        }
    }
}