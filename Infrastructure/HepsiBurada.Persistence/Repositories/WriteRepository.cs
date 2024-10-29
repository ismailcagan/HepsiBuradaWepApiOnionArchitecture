using HepsiBurada.Application.Interface.Repositories;
using HepsiBurada.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace HepsiBurada.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IEntityBase, new()
    {
        private readonly DbContext _dbContex;
        public WriteRepository(DbContext dbContex)
        {
            _dbContex = dbContex;
        }
        private DbSet<T> Table
        {
            get { return _dbContex.Set<T>(); }
        }

        public async Task AddAsync(T entity)
        {
           await Table.AddAsync(entity);
        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }
        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
        public async Task HardDeleteAsync(T entity)
        {
            await Task.Run(()=> Table.Remove(entity));
        }
        public async Task SoftDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
        }
    }
}
