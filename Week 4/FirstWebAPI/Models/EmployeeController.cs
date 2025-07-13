using Microsoft.AspNetCore.Mvc;
using WebApiHandson.Models;
using WebApiHandson.Filters;

namespace WebApiHandson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ServiceFilter(typeof(CustomAuthFilter))] // 🔐 Auth Filter
    public class EmployeeController : ControllerBase
    {
        private static readonly List<Employee> employees = GetStandardEmployeeList();

        // 🔸 GET: api/employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<Employee>> Get()
        {
            // ❗ Uncomment this line to trigger exception for testing
            // throw new Exception("Test exception from GET");
            return Ok(employees);
        }

        // 🔸 GET: api/employee/standard
        [HttpGet("standard")]
        public ActionResult<Employee> GetStandard()
        {
            return Ok(employees.First());
        }

        // 🔸 POST: api/employee
        [HttpPost]
        public IActionResult Post([FromBody] Employee emp)
        {
            employees.Add(emp);
            return CreatedAtAction(nameof(Get), new { id = emp.Id }, emp);
        }

        // 🔸 PUT: api/employee
        [HttpPut]
        public IActionResult Put([FromBody] Employee emp)
        {
            var index = employees.FindIndex(e => e.Id == emp.Id);
            if (index == -1) return NotFound();
            employees[index] = emp;
            return Ok(emp);
        }

        // 🔹 Static method for initial list
        private static List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "HR" },
                    Skills = new List<Skill> { new Skill { Id = 1, Name = "C#" } },
                    DateOfBirth = new DateTime(1990, 5, 24)
                }
            };
        }
    }
}
