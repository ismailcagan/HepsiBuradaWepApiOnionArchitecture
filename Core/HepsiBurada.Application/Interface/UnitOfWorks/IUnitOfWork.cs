using HepsiBurada.Application.Interface.Repositories;
using HepsiBurada.Domain.Common;

namespace HepsiBurada.Application.Interface.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class,IEntityBase,new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class,IEntityBase,new();
        Task<int> SaveAsync();
        int Save();
    }
}
