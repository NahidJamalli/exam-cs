using Exam.Domain.Etities;
using Exam.Infrasturucture.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Services.Abstractions
{
    public interface ILessonService
    {
        Task PostLesson(LessonDto entity);
        Task<IEnumerable<LessonDto>> GetLessonsByClass(int classNum);
        Task<IEnumerable<LessonDto>> GetLessons();
    }
}
