using System;
using System.Collections;

namespace Shop
{
    class CountAllCommand : Commands
    {
        const string COUNTALL = "count all";

        public override void DoCommand(string command, ArrayList list)
        {
            if (command.Equals(COUNTALL))
            {
                int totalCount = 0;
                foreach (Goods goods in list)
                {
                    totalCount += goods.Count;
                }
                Console.WriteLine(totalCount);
            }
        }
    }
}