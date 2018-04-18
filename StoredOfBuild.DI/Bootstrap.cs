using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoredOfBuild.Data;
using StoredOfBuild.Domain;
using StoredOfBuild.Domain.Products;
using System;

namespace StoredOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string con)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(con));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(CategoryStorer));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
