using System;
using ConsoleApp4;


namespace consoleapp4
{
    class program
    {
        static void Main(string[] args)
        {

            ArrayExample obj = new ArrayExample();
            obj.aa[0] = "palani";
            obj.aa[1] = "pky";

            string x = obj.ArrayReadlines(obj.aa[1]);

            Console.WriteLine(x);

            ArrayExample var = new ArrayExample();
            var.aa[1] = "read";
            Console.WriteLine(var.aa[0]);




           


           //new  StudentReport().Readmarks();
           // new StudentReport().CalculateAverage();


            //EmployeeDetail pro = new EmployeeDetail();
            //pro.Name = "hardik";
            //pro.Age = 34;
           // pro.Salary = 34000;
            //pro.score = 123;

           // EmployeeSumary obj = new EmployeeSumary();
           // obj.Data(pro);
            
           


            // ProductDetails pro = new ProductDetails();
            // pro.ProductName = "xy";
            // pro.ProductQuantity = 5;
            // pro.Price = 140;


            // ProductSummary obj = new ProductSummary();
            // obj.Sample(pro);
            //obj.Sample("xy",5,140);


            // parameter obj = new parameter.
            // parameter objb  = new parameter.Method2(a = 63);
            // new Swapping().Metho

        }



    }
}












