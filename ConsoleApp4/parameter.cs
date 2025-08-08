using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class parameter
    {
        string name = "sky";

        public void Method1()
        {
            int a = 18;
            int b = 7;
            Console.WriteLine(a + b);

            Console.WriteLine(this.name);
        }
        public void Method2(int a)
        {
            int b = 45;
            Console.WriteLine(a + b);
        }
    }
       
     
} 
