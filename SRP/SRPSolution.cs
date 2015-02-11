using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeNo { get; set; }
    }

    public class EmployeeDB
    {
        public void Insert(Employee e)
        {
            //Database Logic written here
        }
        public Employee Select()
        {
            return new Employee();
            //Database Logic written here
        }
    }

    public class EmployeeReport
    {
        public void GenerateReport(Employee e)
        {
            //Set report formatting
        }
    }
}
