using DatabaseContextTier.DBContext;
using DatabaseContext.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContextTier.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly CURDDBContext _CURDDBContext;

        public EmployeeRepository(CURDDBContext cURDDBContext)
        {
            _CURDDBContext = cURDDBContext;
        }

        public void DeleteEmployeeById(int EmployeeId)
        {
            Employee employee = _CURDDBContext.Employees.Find(EmployeeId);
            if (employee != null)
            _ = _CURDDBContext.Employees.Remove(employee);
            Save();

        }

        public Employee GetEmployeeById(int EmployeeId)
        {
            return _CURDDBContext.Employees.FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _CURDDBContext.Employees.ToList();
        }

        public void InsertEmployee(Employee employee)
        {
            _CURDDBContext.Employees.Add(employee);
            Save();
        }

        public void Save()
        {
            _CURDDBContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _CURDDBContext.Entry(employee).State = EntityState.Modified;
            Save();
        }
    }
}
