using Microsoft.EntityFrameworkCore;
using ProfileService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.DbContexts
{
	public class ProfileDbContext : DbContext
	{
        public ProfileDbContext(DbContextOptions<ProfileDbContext> options) : base(options)
        {
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>().HasData(
                new Profile
                {
                    Id = 1,
                    FirstName = "Turki",
                    LastName = "Alqurashi",
                    PhonrNumber = "05050505050"
                },
                new Profile
                {
                    Id = 2,
                    FirstName = "Ahmed",
                    LastName = "Alzubaidi",
                    PhonrNumber = "05858585858"
                },
                new Profile
                {
                    Id = 3,
                    FirstName = "Abdulrahman",
                    LastName = "Sarawiq",
                    PhonrNumber = "05858585858"
                }
            );
        }
    }
}
