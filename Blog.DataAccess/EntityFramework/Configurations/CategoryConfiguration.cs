using Blog.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.DataAccess.EntityFramework.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        void IEntityTypeConfiguration<Category>.Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            builder.Property(e => e.Name)
               .HasMaxLength(100)
              
               .IsRequired();
            builder.Property(e => e.CreateDate)
                .HasColumnType("date");
            builder.Property(e => e.UpdateDate)
                .HasColumnType("date");



        }
    }
}
