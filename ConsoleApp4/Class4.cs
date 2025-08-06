using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class b
    {
        public void Method3()
        {
            string a = "ball";
            string b = "bat";
            string c = (a + b);
            Console.WriteLine(c);

        }


        public void Method2()
        {
            string a = "ball";
            string b = "bat";
            string c = (a + b);
            Console.WriteLine(c);

            Method3();
            Method4();
            Method4();
        }



        public void Method5()
        {
            string a = "ball";
            string b = "bat";
            string c = (a + b);
            Console.WriteLine(c);

        }


        public void Method4()
        {
            string a = "ball";
            string b = "bat";
            string c = (a + b);
            Console.WriteLine(c);

        }
    }
}
