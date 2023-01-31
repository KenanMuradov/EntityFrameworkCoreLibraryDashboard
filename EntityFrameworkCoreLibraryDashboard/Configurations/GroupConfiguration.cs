using Microsoft.EntityFrameworkCore;
using EntityFrameworkCoreLibraryDashboard.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EntityFrameworkCoreLibraryDashboard.Configurations;

public class GroupConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasColumnType("nvarchar(10)");

        builder.HasOne(x => x.Faculty)
            .WithMany(x => x.Groups)
            .HasForeignKey(x => x.Id_Faculty);
    }
}
