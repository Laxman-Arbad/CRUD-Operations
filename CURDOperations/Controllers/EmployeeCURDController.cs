using DatabaseContext.Model;
using DatabaseContextTier.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

namespace CURDOperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeCURDController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeCURDController(IEmployeeRepository employeeRepository) 
        { 
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var employee = _employeeRepository.GetEmployees();
            return new OkObjectResult(employee);
        }
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id) 
        {
            var employee = _employeeRepository.GetEmployeeById(id);
            return new OkObjectResult(employee);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            using (var scope = new TransactionScope())
            {
                _employeeRepository.InsertEmployee(employee);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = employee.EmployeeId }, employee);
            }
        }
        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            if (employee != null)
            {
                using (var scope = new TransactionScope())
                {
                    _employeeRepository.UpdateEmployee(employee);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeRepository.DeleteEmployeeById(id);
            return new OkResult();
        }

    }
}
