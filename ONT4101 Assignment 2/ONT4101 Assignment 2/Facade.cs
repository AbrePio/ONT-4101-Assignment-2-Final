using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Facade
    {
        private Pass pass;
        private PassWithDistinction passWithDistinction;
        private Fail fail;
        
        public Facade()
        {
            pass = new Pass();
            passWithDistinction = new PassWithDistinction();
            fail = new Fail();
        }      
        public void DisplayMarkResult(double average)
        {
            Student student = Student.GetStudent();
            Console.Clear();
            Console.WriteLine("\tStudent Mark Report");
            Console.WriteLine("==============================================");
            Console.WriteLine("STDNum: \t\t " + student.studentNo);
            Console.WriteLine("Name: \t\t\t " + student.studentName);
            Console.WriteLine("Surname: \t\t " + student.studentSurname);
            Console.WriteLine("Final Mark: \t\t " + average + "%");
            if (average >= 75)
            {
                passWithDistinction.PassWithDistinctionMethod();
            }
            else if (average > 50 && average < 75)
            {
                pass.PassMethod();
            }
            else if (average < 50)
            {
                fail.FailMethod();
            }
        }
    }
    class Pass
    {
        public void PassMethod()
        {
            Console.WriteLine("Result: \t\t Pass");
            Console.WriteLine("==============================================");
        }
    }
    class PassWithDistinction
    {
        public void PassWithDistinctionMethod()
        {
            Console.WriteLine("Result: \t\t Pass with Distinction");
            Console.WriteLine("==============================================");
        }
    }
    class Fail
    {
        public void FailMethod()
        {
            Console.WriteLine("Result: \t\t Fail");
            Console.WriteLine("==============================================");
        }
    }
}
