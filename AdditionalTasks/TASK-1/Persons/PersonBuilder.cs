using System;

namespace Persons
{
    class PersonBuilder
    {
        const string INPUTNAME = "Input name : ";
        const string INPUTAGE = "Input age : ";

        public Person CreatePerson(int i)
        {
            Inputer inputer = new Inputer();
            Console.WriteLine(String.Format("\nPerson №{0}", i + 1));
            Console.Write(INPUTNAME);
            string name = inputer.InputString();
            Console.Write(INPUTAGE);
            double age = inputer.InputNumber();
            Person person = new Person(name, age);
            return person;
        }
    }
}