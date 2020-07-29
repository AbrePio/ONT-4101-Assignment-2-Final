using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class MySQL
    {
        public double tm1;
        public void enterTM1()
        {
            Console.Write("Please enter Moodle Quizzes Web App mark: ");
            tm1 = double.Parse(Console.ReadLine());
        }

    }
}
