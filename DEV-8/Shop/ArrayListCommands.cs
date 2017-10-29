using System.Collections;

namespace Shop
{
    class ArrayListCommands
    {
        public ArrayList AddToHashOfCommands()
        {
            ArrayList commands = new ArrayList
            {
                new CountTypesCommand(),
                new CountAllCommand(),
                new GetAveragePriceCommand(),
                new GetAveragePriceOfTheTypeCommand()
            };
            return commands;
        }

        public void CallCommand(string command, ArrayList commands, ArrayList goods)
        {
            foreach (Commands com in commands)
            {
                com.DoCommand(command, goods);
            }
        }
    }
}