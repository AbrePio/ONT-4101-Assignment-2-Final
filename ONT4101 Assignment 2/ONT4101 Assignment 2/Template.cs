using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public abstract class Template
    {
        public abstract void Proceed(double avg);
        public virtual void supTest()       // Hook
        {

        }
    }
}
