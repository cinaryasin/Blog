using Core.Entities.BaseEntity;
using Core.Entities.Contracts;
using Core.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Models
{
    public class Post : Entity<int>,IEntity
    {
        public string Title { get; set; }
        public string ContentText { get; set; }

        public int CategoryId { get; set; }
        public int UserId { get; set; }




        public Category Category;
        public User User;


    }
}
