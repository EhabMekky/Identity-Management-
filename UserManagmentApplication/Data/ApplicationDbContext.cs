using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserManagementApplication.Models;

namespace UserManagementApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // change table names
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>(entity => entity.ToTable(name: "Users", "security"));
            builder.Entity<IdentityRole>(entity => entity.ToTable(name: "Roles"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable(name: "UserRoles", "security"));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable(name: "UserClaims", "security"));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable(name: "UserLogins", "security"));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable(name: "RoleClaims", "security"));
            builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable(name: "UserTokens", "security"));

        }
    }
}
