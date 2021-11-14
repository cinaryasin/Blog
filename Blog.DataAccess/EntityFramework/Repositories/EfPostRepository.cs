namespace Blog.DataAccess.EntityFramework.Repositories
{
    using Blog.DataAccess.Contracts;
    using Blog.DataAccess.EntityFramework.Context;
    using Blog.Entities.Models;
    using Core.DataAccess.EntityFramework;
    public class EfPostRepository : EfEntityRepositoryBase<Post, MssqlContext>, IPostRepository
    {
    }
}
