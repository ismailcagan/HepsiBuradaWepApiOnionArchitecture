using HepsiBurada.Domain.Common;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace HepsiBurada.Application.Interface.Repositories
{
    public interface IReadRepository<T> where T : class, IEntityBase , new()
    {
        // Linq sorguları yapmak için yazıldı
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? pradicate = null,
            // birde fazla taployu ve alt tabloları birleştirmek için yazıldı
            Func<IQueryable<T>,IIncludableQueryable<T,object>>? include=null,
            // veriler arasında sıralama yapmak için yazıldı
            Func<IQueryable<T>,IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false);
        // Linq sorguları yapmak için yazıldı
        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? pradicate = null!,
            // birde fazla taployu ve alt tabloları birleştirmek için yazıldı
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null!,
            // veriler arasında sıralama yapmak için yazıldı
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false,
            //  
            int currentPage=1, 
            //
            int pageSize=3);
        
        // Bir tane veri dönecek
        Task<T> GetAsync(Expression<Func<T, bool>> pradicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null!,
            bool enableTracking = false);

        // ToList haline getirilmemiş sorgular
        IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false);

        // bir tablonun sayısını vb. bulmak için kullanıldı.
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);

    }
}
