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
    public class ChoreConfiguration : IEntityTypeConfiguration<Chore>
    {
        public void Configure(EntityTypeBuilder<Chore> builder)
        {
            builder.ToTable("TBL_CHORE");

            //Chave Primária
            builder.HasKey(c => c.Id);

            // Configuração das propriedades
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(c => c.Description)
                .HasColumnType("TEXT");

            builder.Property(c => c.DueDate)
                .IsRequired();

            builder.Property(c => c.Status)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne<User>()
                .WithMany()
                .HasForeignKey(c => c.AssignedToId);
        }
    }
}
