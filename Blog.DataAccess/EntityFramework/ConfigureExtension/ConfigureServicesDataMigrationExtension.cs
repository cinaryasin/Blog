using Blog.DataAccess.Contracts;
using Blog.DataAccess.EntityFramework.Context;
using Blog.DataAccess.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.EntityFramework.ConfigureExtension
{
    public static class ConfigureServicesDataMigrationExtension
    {
        public static void ConfigureServicesDataMigration(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, EfUserRepository>();
            services.AddTransient<ICategoryRepository, EfCategoryRepository>();
            services.AddTransient<IImageRepository, EfImageRepository>();
            services.AddTransient<IPostRepository, EfPostRepository>();
            services.AddTransient<IUserOperationClaimRepository, EfUserOperationClaimRepository>();


            services.AddDbContext<MssqlContext>();
            MssqlContext mssqlContext = new MssqlContext();
            //mssqlContext.Database.EnsureDeleted();
            mssqlContext.Database.EnsureCreated();
            mssqlContext.Database.Migrate();
            
        }

    }

}