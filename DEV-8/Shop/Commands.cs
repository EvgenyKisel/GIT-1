using System.Collections;

namespace Shop
{
    abstract class Commands
    {
        public abstract void DoCommand(string command, ArrayList list); 
    }
}