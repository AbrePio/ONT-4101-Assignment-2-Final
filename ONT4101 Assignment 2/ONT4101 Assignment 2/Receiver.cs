using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public class Receiver
    {
        public double average;
        
        //command pattern
        public List<TestMarks> currentMarks { get; set; }
        public Receiver()
        {
            currentMarks = new List<TestMarks>();
        }

        public void ExecuteCommand(CommandBase command, TestMarks mark)
        {
            command.Execute(this.currentMarks, mark);
        }

        public void ShowCurrentItems()
        {
            foreach (var mark in currentMarks)
            {
                this.average = average + mark.test1;
                this.average = average + mark.test2;
                this.average = average + mark.test3;
                this.average = average + mark.test4;
            }
            Console.WriteLine("Final mark: " + average.ToString());
            Console.WriteLine("-----------------------");
                                

            // template pattern
            ConcreteClass concrete = new ConcreteClass();
            concrete.Proceed(average);
            average = average  + (concrete.tm5 * .10);
            Console.WriteLine("Final: " + average);
            // template pattern end
                                                                    
            // facade pattern
            Facade facade = new Facade();
            facade.DisplayMarkResult(average);
            Pass pass = new Pass();
            PassWithDistinction passWithDistinction = new PassWithDistinction();
            Fail fail = new Fail();
            // facade pattern end
        }
    }        

}

