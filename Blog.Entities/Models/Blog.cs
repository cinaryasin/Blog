﻿using Core.Entities.BaseEntity;
using Core.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Models
{
    public class Blog : Entity<int>,IEntity
    {
        public string MyBlog { get; set; }
    }
}
