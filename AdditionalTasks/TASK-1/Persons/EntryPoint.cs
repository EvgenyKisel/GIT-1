using System;

namespace Persons
{
    class EntryPoint
    {
        const string INPUTCOUNT = "Input integer count : ";
        const string FORMATEXCEPTION = "\n ! It's not a number. Try again";
        const string RESTART = "\nDo you want to try again? (Esc - exit / other key - restart)";

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Inputer inputer = new Inputer();
                    Console.Write(INPUTCOUNT);
                    int count = inputer.InputIntegerNumber();
                    Person[] person = new Person[count];
                    for (int i = 0; i < count; i++)
                    {
                        PersonBuilder personBuilder = new PersonBuilder();
                        bool reenter = true;
                        while (reenter)
                        {
                            try
                            {
                                person[i] = personBuilder.CreatePerson(i);
                            }
                            catch (InputNameException)
                            {
                                continue;
                            }
                            catch (InputAgeException)
                            {
                                continue;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(FORMATEXCEPTION);
                                continue;
                            }
                            reenter = false;
                        }
                    }
                    Outputer outputer = new Outputer();
                    outputer.PrintListOfPeople(person);
                }
                catch (InputIntegerException)
                {
                    continue;
                }
                Console.WriteLine(RESTART);
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}