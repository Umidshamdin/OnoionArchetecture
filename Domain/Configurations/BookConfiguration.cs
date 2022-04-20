using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(200);
            builder.Property(m => m.PageCount).IsRequired();
            builder.Property(m => m.Author).IsRequired().HasMaxLength(100);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
