using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class employee_details
    {
        class Employee_Details
        {
            public string name;
            public short employeeid;
            public int salary;

        }

        class EmployeeSummary
        {


            public void Method1(Employee_Details a)
            {

                a.name = "dgdg";
                a.employeeid = 4500;




                Console.WriteLine(a.name);
                Console.WriteLine(a.salary);
            }
            
        }
    }

}


   

