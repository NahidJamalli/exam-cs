using AutoMapper;
using Exam.Application.Repositories;
using Exam.Application.UnitOfWorks;
using Exam.Domain.Etities;
using Exam.Infrasturucture.Dtos;
using Exam.Infrasturucture.Services.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Infrasturucture.Services.Implementations
{
    public class StudentService : IStudentService
    {
        readonly IGenericRepository<Student> repository;
        readonly IUnitOfWork unitOfWork;
        readonly IMapper mapper;
        public StudentService(IGenericRepository<Student> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<StudentDto>> GetStudents()
        {
            var students = await repository.GetAll().ToListAsync();
            var entities = mapper.Map<IEnumerable<StudentDto>>(students);
            return entities;
        }

        public async Task<IEnumerable<StudentDto>> GetStudentsByClass(int classNum)
        {
            var students = await repository.Where(x => x.ClassNumber == classNum).ToListAsync();
            var entities = mapper.Map<IEnumerable<StudentDto>>(students);
            return entities;
        }

        public async Task PostStudent(StudentDto entity)
        {
            var student = mapper.Map<Student>(entity);
            await repository.AddAsync(student);
            await unitOfWork.CommitAsync();
        }
    }
}
