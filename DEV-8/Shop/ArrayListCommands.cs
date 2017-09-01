using System.Collections;

namespace Shop
{
    class ArrayListCommands
    {
        public ArrayList AddToHashOfCommands()
        {
            ArrayList commands = new ArrayList();
            commands.Add(new CountTypesCommand());
            commands.Add(new CountAllCommand());
            commands.Add(new GetAveragePriceCommand());
            commands.Add(new GetAveragePriceOfTheTypeCommand());
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