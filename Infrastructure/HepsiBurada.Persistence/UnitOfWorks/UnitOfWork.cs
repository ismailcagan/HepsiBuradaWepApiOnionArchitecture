using HepsiBurada.Application.Interface.Repositories;
using HepsiBurada.Application.Interface.UnitOfWorks;
using HepsiBurada.Persistence.Context;
using HepsiBurada.Persistence.Repositories;

namespace HepsiBurada.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext; // Veri Tabanına Erişim Sağlandı
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ValueTask DisposeAsync()
        {
           return _dbContext.DisposeAsync();
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>()
        {
            return new ReadRepository<T>(_dbContext);
        }

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
        {
            return new WriteRepository<T>(_dbContext);
        }
    }
}
