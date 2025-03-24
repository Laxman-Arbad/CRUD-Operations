using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; } = 0;
        public string EmployeeName { get; set; }
        public int EmployeeAge { get; set; }
        public string EmployeeAddress { get; set; }
        public int EmployeeMobile { get; set;}   
        public string EmployeeGender { get; set; }       
        public string EmployeePhone { get; set; }
    }
}
