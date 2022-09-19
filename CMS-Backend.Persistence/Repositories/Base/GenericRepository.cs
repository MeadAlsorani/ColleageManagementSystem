using CMS_Backend.Persistence.ExtensionMethods;
using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.Features.Common;
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
        public readonly ColleageManagementDbContext dbContext;

        public GenericRepository(ColleageManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<T> Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return entity;
        }

        public async Task Delete(int key)
        {
            var entity = await dbContext.Set<T>().FindAsync(key);
            dbContext.Set<T>().Remove(entity!);
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

        public async Task<IReadOnlyList<T>> GetAllWithPagination(ListPaginationRequest request)
        {
            var records=await dbContext.Set<T>().AsQueryable().ApplyPagination(request).ToListAsync();
            return records;
        }

        public Task Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            return Task.CompletedTask;
        }
    }
}
