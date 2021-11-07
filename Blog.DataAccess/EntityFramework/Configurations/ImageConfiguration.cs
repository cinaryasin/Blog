﻿using Blog.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Blog.DataAccess.EntityFramework.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        void IEntityTypeConfiguration<Image>.Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Images");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
        
            builder.Property(e => e.CreateDate)
                .HasColumnType("date");
            builder.Property(e => e.UpdateDate)
                .HasColumnType("date");


           
        }
       
    }
 
}
