using Microsoft.AspNetCore.Mvc;
using Sozinho02.Aplication.ViewModel;
using Sozinho02.Domain.Model;

namespace Sozinho02.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DelEmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public DelEmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var employee = _employeeRepository.GetAll();
            return Ok(employee);
        }
        [HttpPut]
        [Route("\"api/v1/[controller]/DesativarOuAtivarAluno/{id}")]
        public IActionResult Put(int id, [FromForm] ActiveViewEmployee active)
        {
            var employee = _employeeRepository.GetById(id);

            employee.DelActv(active.activen);
            _employeeRepository.Update(employee);
            return Ok(employee);
        }
    }
}
