using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class CommandFactory
    {
        public CommandBase GetCommand(int commandOption)
        {
            switch (commandOption)
            {
                case 1:
                    return new ConcreteCommand();
                default:
                    return new ConcreteCommand();
            }
        }
    }
}
