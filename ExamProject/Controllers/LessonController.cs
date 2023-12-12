using Exam.Domain.Etities;
using Exam.Infrasturucture.Dtos;
using Exam.Infrasturucture.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LessonController : ControllerBase
    {
        readonly ILessonService lessonService;
        public LessonController(ILessonService lessonService)
        {
            this.lessonService = lessonService;
        }

        [HttpPost]
        public async Task<ActionResult> PostLesson(LessonDto lesson)
        {
            await lessonService.PostLesson(lesson);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetLessons()
        {
            var lessons = await lessonService.GetLessons();
            return Ok(lessons);
        }

        [HttpGet]
        public async Task<ActionResult> GetLessonsByClass(int classNum)
        {
            var lessons = await lessonService.GetLessonsByClass(classNum);
            return Ok(lessons);
        }
    }
}
