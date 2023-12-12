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
    public class ExamService : IExamService
    {
        readonly IGenericRepository<ClassExam> repository;
        readonly IUnitOfWork unitOfWork;
        readonly IMapper mapper;
        public ExamService(IGenericRepository<ClassExam> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<ClassExamDto>> Exams()
        {
            var exams = await repository.GetAll().ToListAsync();
            var entities = mapper.Map<IEnumerable<ClassExamDto>>(exams);
            return entities;
        }

        public async Task PostExam(ClassExamDto entity)
        {
            var exam= mapper.Map<ClassExam>(entity);
            await repository.AddAsync(exam);
            await unitOfWork.CommitAsync();
        }
    }
}
