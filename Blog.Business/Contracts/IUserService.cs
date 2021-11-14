using Core.Business;
using Core.Entities.User;
using System.Collections.Generic;


namespace Blog.Business.Contracts
{
    public interface IUserService: IAllService<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
