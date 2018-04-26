using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StoredOfBuild.Data;
using StoredOfBuild.Data.Identity;
using StoredOfBuild.Data.Repositories;
using StoredOfBuild.Domain;
using StoredOfBuild.Domain.Account;
using StoredOfBuild.Domain.Products;
using StoredOfBuild.Domain.Sales;
using System;

namespace StoredOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string con)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(con));

            services.AddIdentity<ApplicationUser, IdentityRole>(config => {

                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 3;
                config.Password.RequireLowercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                //config.Cookies.ApplicationCookie.LoginPath = "/Account/Login";
            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped(typeof(IRepository<Product>), typeof(ProductRepository));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IAuthentication), typeof(Authentication));
            services.AddScoped(typeof(IManager), typeof(Manager));
            services.AddScoped(typeof(CategoryStorer));
            services.AddScoped(typeof(ProductStorer));
            services.AddScoped(typeof(SaleFactory));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));


        }
    }
}
