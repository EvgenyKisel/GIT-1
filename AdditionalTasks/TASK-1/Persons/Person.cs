using System.Text.RegularExpressions;

namespace Persons
{
    class Person
    {
        const string INPUTNAMEEXCEPTION = "\n ! Uncorrect name. Use only letters. Try again";
        const string INPUTAGEEXCEPTION = "\n ! Uncorrect age. Age must be between 0 and 100. Try again";

        private string name;
        private double age;

        public string Name
        {
            get { return name; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z ]+$"))
                {
                    name = value;
                }
                else
                {
                    throw new InputException(INPUTNAMEEXCEPTION);
                }
            }
        }

        public double Age
        {
            get { return age; }
            set
            {
                if (value <= 0 || value > 100)
                {
                    throw new InputException(INPUTAGEEXCEPTION);
                }
                age = value;
            }
        }

        public Person(string name, double age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name.ToString() + ", " + Age.ToString();
        }
    }
}