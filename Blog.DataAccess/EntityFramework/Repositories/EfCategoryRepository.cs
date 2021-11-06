using Blog.DataAccess.Contracts;
using Blog.DataAccess.EntityFramework.Context;
using Blog.Entities.Models;
using Core.DataAccess.EntityFramework;

namespace Blog.DataAccess.EntityFramework.Repositories
{
    public class EfCategoryRepository : EfEntityRepositoryBase<Category, MssqlContext>, ICategoryRepository
    {
        
    }
}
