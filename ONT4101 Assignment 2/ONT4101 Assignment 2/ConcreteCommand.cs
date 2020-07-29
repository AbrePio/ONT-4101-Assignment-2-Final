using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class ConcreteCommand : CommandBase
    {
        public void Execute(List<TestMarks> testMarks, TestMarks newtests)
        {
            testMarks.Add(newtests);
        }
    }
}



