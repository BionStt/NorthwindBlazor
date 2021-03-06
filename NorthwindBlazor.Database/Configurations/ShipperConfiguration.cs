﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NorthwindBlazor.Entities;

namespace NorthwindBlazor.Database.Configurations
{
    public class ShipperConfiguration : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.HasKey(e => e.ShipperId);

            builder.Property(e => e.ShipperId).HasColumnName("ShipperID");

            builder.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(e => e.Phone).HasMaxLength(24);
        }
    }
}
