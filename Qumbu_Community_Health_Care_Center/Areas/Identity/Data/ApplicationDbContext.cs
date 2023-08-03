using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qumbu_Community_Health_Care_Center.Areas.Identity.Data;

namespace Qumbu_Community_Health_Care_Center.Areas.Identity.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());

        builder.Entity<IdentityRole>().HasData(
         new IdentityRole
        {
            Name = "Patient",
            NormalizedName = "PATIENT"
        },
         new IdentityRole
        {
            Name = "Admin",
            NormalizedName = "ADMIN"
        },
         new IdentityRole
        {
            Name = "Nurse",
            NormalizedName = "NURSE"
        },
         new IdentityRole
        {
            Name = "Doctor",
            NormalizedName = "DOCTOR"
         },
         new IdentityRole
        {
            Name = "Unit-Manager",
            NormalizedName = "UNIT-MANAGER"
         },
          new IdentityRole
		{
			Name = "Counsellor",
			NormalizedName = "COUNSELLOR"
          });




	}
    public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(u => u.FirstName).HasMaxLength(255);
            builder.Property(u => u.LastName).HasMaxLength(255);
        }
    }

}
