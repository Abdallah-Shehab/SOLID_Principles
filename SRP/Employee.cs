using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Department { get; set; }
    }

    public class EmployeeYearlySalary
    {

        public decimal CalculateYearlySalary(Employee employee)
        {
            return employee.Salary * 12;
        }
    }


    public class ReportMaker
    {
        public void GenerateReport(Employee employee, string reportType)
        {
            // Code to generate report based on reportType
        }

    }


    public class EmailSender
    {
        public void SendNotification(string recipient, string message)
        {
            // Code to send email notification
        }
    }

}
