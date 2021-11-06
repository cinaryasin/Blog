using Core.DataAccess;
using Core.Entities.User;
using System.Collections.Generic;

namespace Blog.DataAccess.Contracts
{
    public interface IUserRepository : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
