using Core.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.EntityFramework.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        void IEntityTypeConfiguration<User>.Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            builder.Property(e => e.UserName)
               .HasMaxLength(50)
               .IsRequired();
            builder.Property(e => e.FirstName)
               .HasMaxLength(50)
               .IsRequired();
            builder.Property(e => e.LastName)
               .HasMaxLength(50)
               .IsRequired();
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(e => e.PasswordHash)
              .IsRequired();
            builder.Property(e => e.PasswordSalt)
                .IsRequired(false);
            
            builder.Property(e => e.UpdateDate)
                .HasColumnType("date");



        }
    }
}
