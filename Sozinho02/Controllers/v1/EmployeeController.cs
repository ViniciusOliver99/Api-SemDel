using Microsoft.AspNetCore.Mvc;
using Sozinho02.Aplication.ViewModel;
using Sozinho02.Domain.Model;

namespace Sozinho02.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        private readonly Employee _employee;

        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _employeeRepository.GetAll();
            return Ok(employee);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var employee = _employeeRepository.GetById(id);
            return Ok(employee);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put(int id, [FromForm] EmployeeViewModel employeeView)
        {
            var employee = _employeeRepository.GetById(id);

            employee.Up(employeeView.name, employeeView.age, employeeView.photo, employeeView.activen);
            _employeeRepository.Update(employee);
            return Ok(employee);
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _employeeRepository.Delete(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Add([FromForm] EmployeeViewModel EmployeeView)
        {
            var employee = new Employee(EmployeeView.name, EmployeeView.age, EmployeeView.photo, EmployeeView.activen);
            _employeeRepository.Add(employee);
            return Ok();
        }


    }
}
