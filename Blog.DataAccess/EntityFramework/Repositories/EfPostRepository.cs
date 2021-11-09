using Blog.DataAccess.Contracts;
using Blog.DataAccess.EntityFramework.Context;
using Blog.Entities.Models;
using Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.EntityFramework.Repositories
{
    public class EfPostRepository : EfEntityRepositoryBase<Post, MssqlContext>, IPostRepository
    {
    }
}
