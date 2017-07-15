using System.Text.RegularExpressions;

namespace Persons
{
    class Person
    {
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
                    throw new InputNameException();
                }
            }
        }

        public double Age
        {
            get { return age; }
            set
            {
                if (value <= 0 || value > 100) throw new InputAgeException();
                age = value;
            }
        }

        public Person(string name, double age)
        {
            Name = name;
            Age = age;
        }
    }
}