using HealthService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthService.DbContexts
{
	public class HealthDbContext : DbContext
	{
        public HealthDbContext(DbContextOptions<HealthDbContext> options) : base(options)
        {
        }
        public DbSet<PersonalInfo> PersonalInfo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonalInfo>().HasData(
                new PersonalInfo
                {
                    Id = 1,
                    ProfileId = 1,
                    BloodType = "O+",
                    Height = 168,
                    Weight = 72,
                    FitnessLevel = 3,
                },
                new PersonalInfo
                {
                    Id = 2,
                    ProfileId = 2,
                    BloodType = "O+",
                    Height = 169,
                    Weight = 76,
                    FitnessLevel = 2,
                },
               new PersonalInfo
               {
                   Id = 3,
                   ProfileId = 3,
                   BloodType = "A+",
                   Height = 170,
                   Weight = 81,
                   FitnessLevel = 1,
               }
            );
        }
    }
}
