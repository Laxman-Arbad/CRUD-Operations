using DatabaseContext.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContextTier.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetEmployees();
        Employee GetEmployeeById(int EmployeeId);
        void DeleteEmployeeById(int EmployeeId);
        void InsertEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void Save();
    }
}
