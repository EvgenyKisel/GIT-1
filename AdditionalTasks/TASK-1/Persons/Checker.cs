namespace Persons
{
    class Checker
    {
        public void CheckForNegativity(int number)
        {
            if (number <= 0) throw new InputPositiveIntegerException();
        }
    }
}