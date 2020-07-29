using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class OracleAdaptee
    {
        private ITarget itarget;
        public OracleAdaptee(ITarget target)
        {
            itarget = target;
        }

        public void DoTM1()
        {
            itarget.TM1();
        }
        public void DoTM2()
        {
            itarget.TM2();
        }
        public void DoTM3()
        {
            itarget.TM3();
        }
        public void DoTM4()
        {
            itarget.TM4();
        }
    }
}
