using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Etities
{
    public  class Lesson
    {
        [Key]
        public int Id { get; set; }  
        public string LessonCode { get; set; }
        public string Title { get; set; }
        public int ClassNumber { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSurname { get; set; }
    }
}
