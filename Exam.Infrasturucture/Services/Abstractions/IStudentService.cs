using Exam.Domain.Etities;
using Exam.Infrasturucture.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Services.Abstractions
{
    public interface IStudentService
    {
        Task PostStudent(StudentDto entity);
        Task<IEnumerable<StudentDto>> GetStudents();
        Task<IEnumerable<StudentDto>> GetStudentsByClass(int classNum);
    }
}
