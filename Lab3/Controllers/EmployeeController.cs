using lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;



namespace lab3.Controllers
{
    public class EmployeeController : Controller
    {
        [Route("api/DateBase")]
        [ApiController]
        public class EmployeeController : ControllerBase
        {
            private readonly Context_context;

                public EmployeeController(Context context)
            {
                _Context = context;
            }
            [HttpGet("GetFull")]
            public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
            {
                if (_context.Employeers == null!)
                {
                    return NotFound();
                }
                return await _context.Employees.ToListAsync();

            }

            [HttpGet("Employee/{id}")]
            public async Task<ActionResult<Employee>> GetEmployee(int id)
            {
                if (_context.Employeers == null)
                {
                    return NotFound();
                }
                var employee = await _context.Employees.FindAsync(id);
                if (employee == null)
                {
                    return employee;
                }

                [HttpGet("Post/{id}")]
                public async Task<ActionResult<Post>> GetPost(int id)
                {
                    if (_context.Posts == null)
                    {
                        return NotFound();
                    }
                    var post = await _context.Posts.FindAsync(id);
                    if (post == null)
                    {
                        return post;
                    }

                    [HttpPost("Employee")]

                    public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
                    {
                        _сontext.Employees.Add(employee);
                        await _сontext.SaveChangesAsync();

                        return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
                    }

                    [HttpPost("Post")]

                    public async Task<ActionResult<Post>> PostPost(Post post)
                    {
                        _сontext.Posts.Add(post);
                        await _сontext.SaveChangesAsync();

                        return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
                    }

                    [HttpPut("Employee/{id}")]
                    public async Task<IActionResult> PutEmployee(int id, Employee employee)
                    {
                        if (id != employee.Id)
                        {
                            return BadRequest();
                        }
                        return NoContent();
                    }

                    [HttpPut("Post/{id}")]
                    public async Task<IActionResult> PutPost(int id, Post post)
                    {
                        if (id != post.Id)
                        {
                            return BadRequest();
                        }
                        return NoContent();
                    }

                    [HttpDelete("Employee/{id}")]
                    public async Task<IActionResult> DeleteEmployee(int id)
                    {
                        if (_сontext.Employees == null)
                        {
                            return NotFound();
                        }
                        var employee = await _сontext.Employees.FindAsync(id);
                        if (employee == null)
                        {
                            return NotFound();
                        }

                        _сontext.Employees.Remove(employee);
                        await _сontext.SaveChangesAsync();

                        return NoContent();
                    }
                    [HttpDelete("Post/{id}")]
                    public async Task<IActionResult> DeletePost(int id)
                    {
                        if (_сontext.Posts == null)
                        {
                            return NotFound();
                        }
                        var post = await _сontext.Posts.FindAsync(id);
                        if (post == null)
                        {
                            return NotFound();
                        }

                        _сontext.Posts.Remove(post);
                        await _сontext.SaveChangesAsync();

                        return NoContent();

                    }
                }
            }
        }
    }
}