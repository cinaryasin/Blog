using Blog.Entities.Models;
using Core.DataAccess;

namespace Blog.DataAccess.Contracts
{
    public interface IImageRepository : IEntityRepository<Image>
    {
    }
}
