using lab3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace lab3.Controllers
{
    public class StaffController : Controller
    {
        [Route("api/DateBase")]
        [ApiController]
        public class MainController : ControllerBase
        {
            private readonly Context_context;

                public MainController(Context context)S
            {
                _Context = context;
            }
            [HttpGet("GetFull")]
            public async Task<ActionResult<IEnumerable<Staff>>> GetStaff()
            {
                if (_context.Staffs == null!)
                {
                    return NotFound();
                }
                return await _context.Staffs.ToListAsync();

            }

            [HttpGet("Staff/{id}")]
            public async Task<ActionResult<Staff>> GetStaff(int id)
            {
                if (_context.Staffs == null)
                {
                    return NotFound();
                }
                var staff = await _context.Staffs.FindAsync(id);
                if (staff == null)
                {
                    return staff;
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

                    [HttpPost("Staff")]

                    public async Task<ActionResult<Staff>> PostStaff(Staff staff)
                    {
                        _сontext.Staffs.Add(staff);
                        await _сontext.SaveChangesAsync();

                        return CreatedAtAction(nameof(GetStaff), new { id = staff.Id }, staff);
                    }

                    [HttpPost("Post")]

                    public async Task<ActionResult<Post>> PostPost(Post post)
                    {
                        _сontext.Posts.Add(post);
                        await _сontext.SaveChangesAsync();

                        return CreatedAtAction(nameof(GetPost), new { id = post.Id }, post);
                    }

                    [HttpPut("Staff/{id}")]
                    public async Task<IActionResult> PutStaff(int id, Staff staff)
                    {
                        if (id != staff.Id)
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

                    [HttpDelete("Staff/{id}")]
                    public async Task<IActionResult> DeleteStaff(int id)
                    {
                        if (_сontext.Staffs == null)
                        {
                            return NotFound();
                        }
                        var staff = await _сontext.Staffs.FindAsync(id);
                        if (staff == null)
                        {
                            return NotFound();
                        }

                        _сontext.Staffs.Remove(staff);
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