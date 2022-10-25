using CMS_Backend.Persistence.ExtensionMethods;
using CMS_BackEnd.Application.Contracts.Base;
using CMS_BackEnd.Application.DTOs.Common;
using CMS_BackEnd.Application.Features.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
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
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task Delete(int key)
        {
            var entity = await dbContext.Set<T>().FindAsync(key);
            dbContext.Remove(entity!);
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await dbContext.Set<T>().FindAsync(id) != null;
        }

        public virtual async Task<T> Get(int id)
        {
            var record = await dbContext.Set<T>().FindAsync(id);
            return record!;
        }

        public virtual async Task<IReadOnlyList<T>> GetAll()
        {
            return await dbContext.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<PaginationResponse<T>> GetAllWithPagination(ListPaginationRequest request)
        {

            var records = await dbContext.Set<T>().OrderByDescending("CreationDate").AsNoTracking().ApplyPagination(request).ToListAsync();
            var count = await dbContext.Set<T>().AsNoTracking().CountAsync();
            return new PaginationResponse<T> { Count = count, Records = records };
        }

        public virtual async Task Update(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync();
            return;
        }
    }
}
