using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class SQLite
    {
        public double tm2;
        public void enterTM2()
        {
            Console.Write("Please enter Practical Mobile App mark: ");
            tm2 = double.Parse(Console.ReadLine());
        }
      
    }
}
