using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ONT4101_Assignment_2.ConcreteCommand;

namespace ONT4101_Assignment_2
{
    public class Invoker
    {
        private CommandBase commandBase;
        private TestMarks testMark;
        private Receiver receiver;

        public Invoker()
        {
            receiver = new Receiver();
        }

        public void SetCommand(int commandOption)
        {
            commandBase = new CommandFactory().GetCommand(commandOption);
        }

        public void SetTestMark(TestMarks mark)
        {
            testMark = mark;
        }

        public void ExecuteCommand()
        {
            receiver.ExecuteCommand(commandBase, testMark);
        }

        public void ShowCurrentOrder()
        {
            receiver.ShowCurrentItems();
        }
    }
}
