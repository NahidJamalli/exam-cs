using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Domain.Etities
{
    public class ClassExam
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("LessonId")]
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        [ForeignKey("StudentId")]
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public DateTime DateOfExam { get; set; }
        public decimal Result { get; set; }
    }
}
