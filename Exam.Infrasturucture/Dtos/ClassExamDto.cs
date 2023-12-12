using Exam.Domain.Etities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Dtos
{
    public class ClassExamDto
    {
        public int LessonId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateOfExam { get; set; }
        public decimal Result { get; set; }
    }
}
