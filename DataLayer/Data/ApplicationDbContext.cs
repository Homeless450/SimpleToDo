using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models;
using Shared;

namespace DataLayer.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Goal> Goals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, FirstName = "FirstName1", LastName = "LastName1", Phone = "123321", Patronymic = "Namowich" },
                new User {Id = 2, FirstName = "FirstName1", LastName = "LastName2", Phone = "123321", Patronymic = "Namowich" }
                );

            modelBuilder.Entity<Goal>().HasData(
                new Goal { Id = 1, Name = "eat burger in the morning", EndDay = DateTime.Now.AddDays(2), StartDay = DateTime.Now, UserId = 1 },
                new Goal { Id = 2, Name = "drink cola in the morning", EndDay = DateTime.Now.AddDays(2), StartDay = DateTime.Now, UserId = 1 },
                new Goal { Id = 3, Name = "go to gym", EndDay = DateTime.Now.AddDays(3), StartDay = DateTime.Now, UserId = 2 },
                new Goal { Id = 4, Name = "go to bass", EndDay = DateTime.Now.AddDays(4), StartDay = DateTime.Now, UserId = 2 },

                //completed

                new Goal { Id = 5, Name = "go to bass", EndDay = DateTime.Now, Completed = true, StartDay = DateTime.Now.AddDays(-1), UserId = 2 },
                new Goal { Id = 6, Name = "study .Net", EndDay = DateTime.Now, Completed = true, StartDay = DateTime.Now.AddDays(-1), UserId = 2 }
                );


            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = SD.Role_User },
                new IdentityRole { Name = SD.Role_Admin}
                );

        }
    }
}