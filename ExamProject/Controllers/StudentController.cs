using Exam.Domain.Etities;
using Exam.Infrasturucture.Dtos;
using Exam.Infrasturucture.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost]
        public async Task<ActionResult> PostStudent(StudentDto student)
        {
            await studentService.PostStudent(student);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            var response = await studentService.GetStudents();
            return Ok(response);
        }

        [HttpGet]
        public async Task<ActionResult> GetStudentsByClass(int classNum)
        {
            var response = await studentService.GetStudentsByClass(classNum);
            return Ok(response);
        }
    }
}
