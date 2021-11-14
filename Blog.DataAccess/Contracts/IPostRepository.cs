namespace Blog.DataAccess.Contracts
{
    using Blog.Entities.Models;
    using Core.DataAccess;
    public interface IPostRepository : IEntityRepository<Post>
    {
        
    }
}
