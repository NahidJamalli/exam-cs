using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Dtos
{
    public class LessonDto
    {
        public string LessonCode { get; set; }
        public string Title { get; set; }
        public int ClassNumber { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
