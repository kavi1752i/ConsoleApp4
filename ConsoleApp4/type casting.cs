using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Typecasting
    {
        string name = " rohit";
        char Gender = 'm';
        int a = 45;
        
       

        public void Method1()
        {
            string name = "hardik";
            
            Console.WriteLine(this.name + name);
            
            Console.WriteLine(this.Gender);
            
            Method2();
        }
        public void Method2()
        {
            int b = 63;
            Console.WriteLine(b);
            Console.WriteLine(this.name);
            

        }
        public void Method3()
        {
            Console.WriteLine(a);
            Console.WriteLine(this.name);
        }
        
    }
}
 

       

      


      
      

