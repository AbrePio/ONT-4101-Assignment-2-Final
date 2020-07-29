using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONT4101_Assignment_2
{
    public sealed class Student
    {
        public static Student instance;
        public static object _lock = new object();
        public string studentNo { get; set; }
        public string studentName { get; set; }
        public string studentSurname { get; set; }

        public Student()
        {
            this.studentNo = studentNo;
            this.studentName = studentName;
            this.studentSurname = studentSurname;
        }
        public static Student GetStudent()
        {
            lock (_lock)
            {
                if(instance == null)
                {
                    instance = new Student();
                }
                return instance;
            }
        }

    }
}
