using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Firebase
    {
        public double tm3;
        public void enterTM3()
        {
            Console.Write("Please enter Test Mobile App mark: ");
            tm3 = double.Parse(Console.ReadLine());
        }
      
    }
}
