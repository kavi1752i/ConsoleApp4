using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class ProductSummary
    {
        public void Sample(string name, int quantity, double price)
        {
            Console.WriteLine(name);
            Console.WriteLine(quantity);
            Console.WriteLine(price);
        }
        public void Sample(ProductDetails s)
        {
            Console.WriteLine(s.ProductName);
            Console.WriteLine(s.ProductQuantity);
            Console.WriteLine(s.Price);
        }
        
        

        
    }
}
