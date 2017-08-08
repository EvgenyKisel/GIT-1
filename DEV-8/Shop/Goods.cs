using System.Text.RegularExpressions;

namespace Shop
{
    class Goods
    {
        const string INPUTTYPEEXCEPTION = "\n ! Uncorrect type. Use only letters. Try again";
        const string INPUTCOUNTEXCEPTION = "\n ! Uncorrect count. Count can't be negative. Try again";
        
        private string type;
        private string name;
        private int count;
        private double price;

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z ]+$"))
                {
                    type = value;
                }
                else
                {
                    throw new InputException(INPUTTYPEEXCEPTION);
                }
            }
        }

        public string Name
        {
            get => name;
            set => name = value; 
        }

        public int Count
        {
            get => count;
            set
            {
                if (count < 0)
                {
                    throw new InputException(INPUTCOUNTEXCEPTION);
                }
                count = value;
            }
        }

        public double Price
        {
            get => price;
            set => price = value;
        }
    }
}