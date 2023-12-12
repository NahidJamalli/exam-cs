using AutoMapper;
using Exam.Domain.Etities;
using Exam.Infrasturucture.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Mapping
{
    public class Map:Profile
    {
        public Map()
        {
            CreateMap<Lesson, LessonDto>().ReverseMap();
            CreateMap<ClassExam, ClassExamDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
        }
    }
}
