using Core.Entities.BaseEntity;
using Core.Entities.Contracts;

namespace Core.Entities.User
{
    public class UserOperationClaim : Entity<int>, IEntity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public User User;
        public OperationClaim OperationClaim;
    }
}
