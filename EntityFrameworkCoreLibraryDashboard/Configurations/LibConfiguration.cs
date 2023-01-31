using EntityFrameworkCoreLibraryDashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace EntityFrameworkCoreLibraryDashboard.Configurations;

public class LibConfiguration : IEntityTypeConfiguration<Lib>
{
    public void Configure(EntityTypeBuilder<Lib> builder)
    {
        builder.Property(x => x.FirstName)
            .IsRequired()
            .HasColumnType("nvarchar(15)");

        builder.Property(x => x.LastName)
            .IsRequired()
            .HasColumnType("nvarchar(25)");
    }
}
