using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDbPOC.Models;
using MongoDbPOC.Services;

namespace MongoDbPOC.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private readonly StudentService _studentService;

		public StudentsController(StudentService studentService)
		{
			_studentService = studentService;
		}
		[HttpGet(Name = "GetStudents")]
		public ActionResult<List<Student>> Get() =>
			_studentService.Get();

		[HttpGet("{id:length(24)}", Name = "GetStudent")]
		public ActionResult<Student> Get(string id)
		{
			var book = _studentService.Get(id);

			if (book == null)
			{
				return NotFound();
			}

			return book;
		}
		[HttpPost]
		public ActionResult<Student> Create(Student student)
		{
			_studentService.Create(student);

			return CreatedAtRoute("GetStudent", new { id = student.Id.ToString() }, student);
		}
		[HttpPut]
		public IActionResult Update(Student student)
		{
			var dbStudent = _studentService.Get(student.Id);

			if (dbStudent == null)
			{
				return NotFound();
			}

			_studentService.Update(student);

			return Ok(student);
		}
		[HttpDelete("{id:length(24)}")]
		public async Task<IActionResult> DeleteAsync(string id)
		{
			var student = _studentService.Get(id);

			if (student == null)
			{
				return NotFound();
			}

			await _studentService.RemoveAsync(student.Id);

			return NoContent();
		}

	}
}
