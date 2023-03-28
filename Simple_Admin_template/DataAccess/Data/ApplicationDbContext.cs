using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Simple_Admin_template.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            IdentityUser user = new IdentityUser
            {
                UserName = "aitorAdmin@test.com",
                NormalizedUserName = "AITORADMIN@TEST.COM",
                Email = "aitorAdmin@test.com",
                NormalizedEmail = "AITORADMIN@TEST.COM",
                EmailConfirmed = true,
            };
            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(user);
            user.PasswordHash = hasher.HashPassword(user, "admintest123");

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}