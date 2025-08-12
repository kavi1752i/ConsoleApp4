using System;
using ConsoleApp4;


namespace consoleapp4
{
    class program
    {
        static void Main(string[] args)
        {



            ProductDetails pro = new ProductDetails();
            pro.ProductName = "xy";
            pro.ProductQuantity = 5;
            pro.Price = 140;
           
            

            ProductSummary obj = new ProductSummary();
            obj.Sample(pro);
            obj.Sample("xy",5,140);
       
            
            
            
         


            // parameter obj = new parameter.
            // parameter objb  = new parameter.Method2(a = 63);
            // new Swapping().Metho

        }
            
        

    }
}












