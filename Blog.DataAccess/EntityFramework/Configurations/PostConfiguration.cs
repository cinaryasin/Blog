using Blog.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccess.EntityFramework.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        void IEntityTypeConfiguration<Post>.Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.Property(e => e.Id)
                   .ValueGeneratedOnAdd();
            builder.Property(e => e.Title)
                   .HasMaxLength(150)
                   .IsRequired();
            builder.Property(e => e.ContentText)
                   .IsRequired();
            builder.HasOne(x => x.User)
                   .WithMany()
                   .HasForeignKey(x => x.UserId)
                   .IsRequired();
            builder.HasOne(x => x.Category)
                   .WithMany()
                   .HasForeignKey(x => x.CategoryId)
                   .IsRequired();
            builder.Property(e => e.CreateDate)
                   .HasColumnType("date");
            builder.Property(e => e.UpdateDate)
                   .HasColumnType("date");  

        }
    }
}
