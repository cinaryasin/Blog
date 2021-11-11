using Core.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccess.EntityFramework.Configurations
{
    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        void IEntityTypeConfiguration<UserOperationClaim>.Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            builder.ToTable("UserOperationClaims");
            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd();            
            builder.HasOne(x => x.User)
                   .WithMany()
                   .HasForeignKey(x => x.UserId)
                   .IsRequired();
            builder.HasOne(x => x.OperationClaim)
                   .WithMany()
                   .HasForeignKey(x => x.OperationClaimId)
                   .IsRequired();
            builder.Property(e => e.CreateDate)
                   .HasColumnType("date");
            builder.Property(e => e.UpdateDate)
                   .HasColumnType("date");

        }
    }
}
