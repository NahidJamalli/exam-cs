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
    public class LessonService : ILessonService
    {
        readonly IGenericRepository<Lesson> repository;
        readonly IUnitOfWork unitOfWork;
        readonly IMapper mapper;
        public LessonService(IGenericRepository<Lesson> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<LessonDto>> GetLessons()
        {
            var lessons = await repository.GetAll().ToListAsync();
            var entities = mapper.Map<IEnumerable<LessonDto>>(lessons);
            return entities;
        }
        
        public async Task<IEnumerable<LessonDto>> GetLessonsByClass(int classNum)
        {
            var lessons = await repository.Where(x => x.ClassNumber == classNum).ToListAsync();
            var entities = mapper.Map<IEnumerable<LessonDto>>(lessons);
            return entities;
        }

        public async Task PostLesson(LessonDto entity)
        {
            var lesson= mapper.Map<Lesson>(entity);
            await repository.AddAsync(lesson);
            await unitOfWork.CommitAsync();
        }
    }
}
