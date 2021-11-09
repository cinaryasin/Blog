using Blog.Entities.Models;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Contracts
{
    public interface IPostRepository : IEntityRepository<Post>
    {
        
    }
}
