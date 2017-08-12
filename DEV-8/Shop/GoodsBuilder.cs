using System;

namespace Shop
{
    class GoodsBuilder
    {
        const string INPUTTYPE = "Input type : ";
        const string INPUTNAME = "Input name : ";
        const string INPUTCOUNT = "Input count : ";
        const string INPUTPRICE = "Input price : ";

        public Goods CreateGoods(int i)
        {
            Inputer inputer = new Inputer();
            Console.WriteLine(String.Format("\nGoods №{0}", i + 1));
            Console.Write(INPUTTYPE);
            string type = inputer.InputString();
            Console.Write(INPUTNAME);
            string name = inputer.InputString();
            Console.Write(INPUTCOUNT);
            int count = inputer.InputInteger();
            Console.Write(INPUTPRICE);
            double price = inputer.InputDouble();
            return new Goods(type, name, count, price);
        }
    }
}