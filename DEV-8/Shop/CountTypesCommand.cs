using System;
using System.Collections;

namespace Shop
{
    class CountTypesCommand : Commands
    {
        const string COUNTTYPES = "count types";

        public override void DoCommand(string command, ArrayList list)
        {
            if (command.Equals(COUNTTYPES))
            {
                Console.WriteLine(list.Count);
            }
        }
    }
}