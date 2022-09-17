using CMS_BackEnd.Application.Contracts.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS_Backend.Persistence.Repositories.Base
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext dbContext;

        public GenericRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<T> Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public async Task<bool> Exists(int id)
        {
            return await dbContext.Set<T>().FindAsync(id) != null;
        }

        public async Task<T> Get(int id)
        {
            var record = await dbContext.Set<T>().FindAsync(id);
            return record!;
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

        public Task Update(T entity)
        {
            dbContext.Entry(entity).State= EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
