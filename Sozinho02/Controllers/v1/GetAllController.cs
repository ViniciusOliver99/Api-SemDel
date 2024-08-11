using Microsoft.AspNetCore.Mvc;
using Sozinho02.Domain.Model;

namespace Sozinho02.Controllers.v1
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class GetAllController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;
        public GetAllController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        [HttpGet]
        public IActionResult GetFalseAndTre()
        {
            var employees = _employeeRepository.GetFalseAndTre();
            return Ok(employees);
        }
    }
}
