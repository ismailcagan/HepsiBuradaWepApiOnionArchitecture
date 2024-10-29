using HepsiBurada.Application.Interface.Repositories;
using HepsiBurada.Persistence.Context;
using HepsiBurada.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HepsiBurada.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services,IConfiguration configuration)
        {
            // Veri tabanı baglantisi
            services.AddDbContext<AppDbContext>(opt =>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            // GenericRepository IReadRepository
            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));

            // GenericRepository IWriteRepository
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
        }
    }
}
