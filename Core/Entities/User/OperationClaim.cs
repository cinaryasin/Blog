using Core.Entities.BaseEntity;
using Core.Entities.Contracts;

namespace Core.Entities.User
{
    public class OperationClaim : Entity<int>, IEntity
    {
        public string Name { get; set; }
    }
}
