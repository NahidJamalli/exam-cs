using Exam.Application.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Application.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        readonly ExamDbContext examDbContext;
        readonly DbSet<T> dbSet;
        public GenericRepository(ExamDbContext examDbContext)
        {
            dbSet = examDbContext.Set<T>();
            this.examDbContext = examDbContext;
        }

        public async Task AddAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public IQueryable<T> GetAll()
        {
            return dbSet;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

      

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

       
        public IQueryable<T> Where(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate);
        }
    }
}
