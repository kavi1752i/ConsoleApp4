using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class StudentReport
    {
        public int total;
        public int average;

        public int Readmarks()
        {
            Console.WriteLine("enter your tamilmark");
            int tamil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your englishmark");
            int english = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your mathsmarks");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your commerce marks");
            int commerce = Convert.ToInt32(Console.ReadLine());

            total = tamil + english + maths + commerce;

            return total;

        }

        public long CalculateAverage()
        {
            average = total / 4;
            return average;  


        }

    }



 }

    