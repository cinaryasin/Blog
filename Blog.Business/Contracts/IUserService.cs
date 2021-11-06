using Core.Business;
using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Contracts
{
    public interface IUserService: IAllService<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
