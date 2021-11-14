using Blog.Business.Contracts;
using Blog.Business.Services;
using Blog.DataAccess.EntityFramework.ConfigureExtension;
using Core.Utilities.Security.Token;
using Core.Utilities.Security.Token.JWT;
using Microsoft.Extensions.DependencyInjection;


namespace Blog.Business
{
    public static class BusinessServiceRegistry
    {
        public static void EnableBusinessServices(this IServiceCollection services)
        {
            
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IImageService, ImageService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IUserOperationClaimService, UserOperationClaimService>();


            services.AddTransient<ITokenHelper, JwtHelper>();
           


            services.ConfigureServicesDataMigration();


            //services.AddTransient(typeof(IUserService), typeof(UserManager));
        }
    }
}


