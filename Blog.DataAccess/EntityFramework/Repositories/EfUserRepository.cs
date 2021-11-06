using Blog.DataAccess.Contracts;
using Blog.DataAccess.EntityFramework.Context;
using Core.DataAccess.EntityFramework;
using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.EntityFramework.Repositories
{
    public class EfUserRepository : EfEntityRepositoryBase<User, MssqlContext>, IUserRepository
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MssqlContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
