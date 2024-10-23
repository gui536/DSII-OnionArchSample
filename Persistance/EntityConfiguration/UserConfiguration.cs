using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("TBL_USER");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(u => u.Email)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(u => u.Password)
                .HasMaxLength(255)
                .IsRequired();
            builder.Property(u => u.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("SYSDATETIMEOFFSET()");
        }
    }
}
