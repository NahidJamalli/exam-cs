using Exam.Application.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Application.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {

        readonly ExamDbContext examDbContext;
        public UnitOfWork(ExamDbContext examDbContext)
        {
            this.examDbContext = examDbContext;
        }

        public void Commit()
        {
            examDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await examDbContext.SaveChangesAsync();
        }
    }
}

