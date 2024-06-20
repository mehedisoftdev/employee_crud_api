using APIExamples.Data;
using APIExamples.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore;

namespace APIExamples.Controllers
{
    [Route("api/employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDBContext _context;
        public EmployeesController(AppDBContext context)
        {
            _context = context;
        }

        // api/Employees
        [HttpGet("all")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            try
            {
                var employees = await _context.Employees.ToListAsync();
                return StatusCode(StatusCodes.Status200OK, new CommonResponse()
                {
                    IsSuccess = true,
                    Message = "Data read success",
                    Employees = employees
                });
            }catch(Exception ex) 
            {

                return StatusCode(StatusCodes.Status200OK, new CommonResponse()
                {
                    IsSuccess = false,
                    Message = "Data read unsuccess",
                    Employees = new List<Employee>()
                });
            }
        }

        // api/employees?employeeId = 5
        [HttpGet]
        public async Task<ActionResult<Employee>> GetEmployee([FromQuery] int employeeId)
        {
            var employee = await _context.Employees.FindAsync(employeeId);
            if(employee == null)
            {
                return NotFound(new { error = $"The employee of Id: {employeeId} is not found." });
            }
            return StatusCode(StatusCodes.Status200OK, new CommonResponse() {
                IsSuccess = true,
                Message = "Data read success",
                Employees = new List<Employee>()
                {
                    employee
                }
            });
        }

        // POST: api/employees/save
        [HttpPost("save")]
        public async Task<ActionResult<Employee>> PostEmployee([FromBody] Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                CommonResponse response = new CommonResponse()
                {
                    IsSuccess = true,
                    Message = $"Employee Id: {employee.Id} is saved successfully",
                    Employees = new List<Employee> { employee }
                };
                return CreatedAtAction(nameof(GetEmployee), new { employeeId = employee.Id }, response);
            }
            catch (Exception ex)
            {
                CommonResponse response = new CommonResponse()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Employees = new List<Employee>()
                };
                return StatusCode(StatusCodes.Status500InternalServerError, response);
            }
        }

        // PUT: api/employees/update?employeeId=5
        [HttpPut("update")]
        public async Task<ActionResult> PutEmployee([FromQuery] int employeeId, [FromBody] Employee employee)
        {
            if(employeeId != employee.Id)
            {
                return StatusCode(StatusCodes.Status404NotFound, new CommonResponse()
                {
                    IsSuccess = false,
                    Message = $"Employee Id: {employee.Id} is not found",
                    Employees = new List<Employee>()
                }); 
            }
            _context.Entry(employee).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                return StatusCode(StatusCodes.Status200OK, new CommonResponse()
                {
                    IsSuccess = true,
                    Message = $"Employee Id: {employee.Id} has been successfully updated",
                    Employees = new List<Employee>() { employee }
                });
            } catch (Exception ex) {
                if(!EmployeeExists(employeeId))
                {
                    return StatusCode(StatusCodes
                        .Status500InternalServerError, new CommonResponse()
                        {
                            IsSuccess = false,
                            Message = $"Employee Id: {employee.Id} is not exists",
                            Employees = new List<Employee>()
                        });
                }
                else
                {
                    return StatusCode(StatusCodes
                        .Status500InternalServerError, new CommonResponse()
                        {
                            IsSuccess = false,
                            Message = ex.Message,
                            Employees = new List<Employee>(),
                        });
                }
            }
        }

        // DELETE: api/employees/delete?employeeId=5
        [HttpDelete("delete")]
        public async Task<ActionResult> DeleteEmployee([FromQuery] int employeeId)
        {
            try
            {
                var employee = await _context.Employees.FindAsync(employeeId);
                if (employee == null) { return NotFound(); }
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
                return StatusCode(StatusCodes.Status200OK, new CommonResponse()
                {
                    IsSuccess = true,
                    Message = $"Employee Id : {employeeId} has been successfully deleted",
                    Employees = new List<Employee>() {employee}
                });
            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new CommonResponse()
                {
                    IsSuccess = false,
                    Message = ex.Message,
                    Employees = new List<Employee>(),
                });
            }
            
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }

    }
}
