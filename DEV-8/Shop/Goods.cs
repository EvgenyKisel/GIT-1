using System.Text;
using System.Text.RegularExpressions;

namespace Shop
{
    class Goods
    {
        const string INPUTTYPEEXCEPTION = "\n ! Uncorrect type. Use only letters. Try again";
        const string INPUTCOUNTEXCEPTION = "\n ! Uncorrect count. Count can't be negative. Try again";
        const string INPUTPRICEEXCEPTION = "\n ! Uncorrect price. Price can't be negative. Try again";

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
            set
            {
                if (price < 0)
                {
                    throw new InputException(INPUTPRICEEXCEPTION);
                }
                price = value;
            }
        }

        public Goods(string type, string name, int count, double price)
        {
            Type = type;
            Name = name;
            Count = count;
            Price = price;
        }

        public override string ToString()
        {
            StringBuilder goods = new StringBuilder();
            goods.AppendLine(Type + " " + Name + " " + Count + " " + Price);
            return goods.ToString();
        }
    }
}