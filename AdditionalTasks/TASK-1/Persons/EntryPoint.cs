﻿using System;

namespace Persons
{
    class EntryPoint
    {
        const string INPUTCOUNT = "Input integer count : ";
        const string FORMATEXCEPTION = "\n ! It's not a number. Try again\n";
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Inputer inputer = new Inputer();
                    Console.Write(INPUTCOUNT);
                    int personsCount = inputer.InputIntegerNumber();
                    Checker checker = new Checker();
                    checker.CheckForNegativity(personsCount);
                    Person[] person = new Person[personsCount];
                    for (int i = 0; i < personsCount; i++)
                    {
                        PersonBuilder personBuilder = new PersonBuilder();
                        bool reenter = true;
                        while (reenter)
                        {
                            try
                            {
                                person[i] = personBuilder.CreatePerson(i);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                continue;
                            }
                            reenter = false;
                        }
                    }
                    Outputer outputer = new Outputer();
                    outputer.PrintListOfPeople(person);
                }
                catch (InputPositiveIntegerException)
                {
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}