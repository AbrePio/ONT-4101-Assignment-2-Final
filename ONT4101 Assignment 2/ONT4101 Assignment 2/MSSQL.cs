using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class MSSQL
    {
        public double tm4;
        public void enterTM4()
        {
            Console.Write("Please enter Assignment Web App mark: ");
            tm4 = double.Parse(Console.ReadLine());
        }

    }
}
