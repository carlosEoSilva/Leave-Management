using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Data
{
    //note-2
    //note-
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "32f3dc8c-1884-407d-b938-362aa2b9d59e",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                },
                new IdentityRole
                {
                    Id = "d485abbe-0f02-4bd1-ba44-6352659af68a",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR"
                },
                new IdentityRole
                {
                    Id = "f54935f0-7d3b-45aa-ae9b-b864e0170453",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });


            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0",
                    Email = "admin@email.com",
                    NormalizedEmail = "ADMIN@EMAIL.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "password1"),
                    EmailConfirmed = true,
                    FirstName = "Default",
                    LastName = "Admim",
                    DateOfBirth = new DateOnly(1950, 12, 01)
                });

            //note-13
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "f54935f0-7d3b-45aa-ae9b-b864e0170453",
                    UserId = "6a331ac0-cf0e-49d1-8a18-6f7298ca90a0"
                });
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
