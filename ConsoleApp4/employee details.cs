using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class employeedetails
    {
        class EmployeeDetails
        {
            public string name;
            public short employeeid;
            public int salary;

        }

        class EmployeeSummary
        {

            public void Method(EmployeeDetails a)
            {
                Console.WriteLine(a.name);
                Console.WriteLine(a.salary);
            }
            
        }
    }

}


   

