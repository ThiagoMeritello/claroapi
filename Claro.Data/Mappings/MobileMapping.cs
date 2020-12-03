using Claro.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Claro.Data.Mappings
{
    public class MobileMapping : IEntityTypeConfiguration<Mobile>
    {
        public void Configure(EntityTypeBuilder<Mobile> builder)
        {
            builder.HasKey(p => p.Code);

            builder.Property(p => p.Date)
                .HasColumnType("varchar(10)");

            builder.ToTable("Mobile");
        }
    }
}