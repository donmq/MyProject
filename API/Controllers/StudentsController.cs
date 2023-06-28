using API.Data;
using API.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly MyDbContext _myDbContext;
        public StudentsController(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAsync()
        {
            var students = await _myDbContext.Students.ToListAsync();
            return Ok(students);
        }
        [HttpGet("GetID")]
        public async Task<IActionResult> GetStudentByIdAsync(int id)
        {
            var student = await _myDbContext.Students.FindAsync(id);
            return Ok(student);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> PostAsync(Students student)
        {
            _myDbContext.Students.Add(student);
            await _myDbContext.SaveChangesAsync();
            return Created($"/get-student-by-id?id={student.Id}", student);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> PutAsync(Students studentToUpdate)
        {
            _myDbContext.Students.Update(studentToUpdate);
            await _myDbContext.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var studentToDelete = await _myDbContext.Students.FindAsync(id);
            if (studentToDelete == null)
            {
                return NotFound();
            }
            _myDbContext.Students.Remove(studentToDelete);
            await _myDbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}