using Blog.DataAccess.Contracts;
using Blog.DataAccess.EntityFramework.Context;
using Core.DataAccess.EntityFramework;
using Core.Entities.User;

namespace Blog.DataAccess.EntityFramework.Repositories
{
    public class EfUserOperationClaimRepository : EfEntityRepositoryBase<UserOperationClaim, MssqlContext>, IUserOperationClaimRepository
    {
    }
}
