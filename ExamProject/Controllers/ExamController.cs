using Azure;
using Exam.Domain.Etities;
using Exam.Infrasturucture.Dtos;
using Exam.Infrasturucture.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        readonly IExamService examService;
        public ExamController(IExamService examService)
        {
            this.examService = examService;
        }

        [HttpPost]
        public async Task<ActionResult> PostExam(ClassExamDto classExam)
        {
            await examService.PostExam(classExam);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetExams()
        {
            var response = await examService.Exams();
            return Ok(response);
        }
    }
}
