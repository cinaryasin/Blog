using Blog.Business.Contracts;
using Blog.Business.Services;
using Blog.DataAccess.EntityFramework.ConfigureExtension;
using Core.Utilities.Security.JWT;
using Core.Utilities.Uploads.FileHelper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business
{
    public static class BusinessServiceRegistry
    {
        public static void EnableBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IImageService, ImageService>();
            

            services.AddTransient<ITokenHelper, JwtHelper>();
           


            services.ConfigureServicesDataMigration();


            //services.AddTransient(typeof(IUserService), typeof(UserManager));
        }
    }
}


