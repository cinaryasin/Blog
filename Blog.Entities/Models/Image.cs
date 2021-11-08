using Core.Entities.BaseEntity;
using Core.Entities.Contracts;
using Core.Entities.User;
using System.Text.Json.Serialization;

namespace Blog.Entities.Models
{
    public class Image : Entity<int>, IEntity
    {
        public string ImagePath { get; set; }
        public int UserId { get; set; }


        [JsonIgnore]
        public User User;
    }
}
