using Microsoft.EntityFrameworkCore;
using ProfileService.DbContexts;
using ProfileService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.Repository
{
	public class ProfileRepository : IProfileRepository
	{
		private readonly ProfileDbContext _dbContext;

		public ProfileRepository(ProfileDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public void DeleteProfile(int ProfileId)
		{
			var profile = _dbContext.Profiles.Find(ProfileId);
			_dbContext.Profiles.Remove(profile);
			Save();
		}

		public Profile GetProfileById(int ProfileId)
		{
			return _dbContext.Profiles.Find(ProfileId);
		}

		public IEnumerable<Profile> GetProfiles()
		{
			return _dbContext.Profiles.ToList();
		}

		public void InsertProfile(Profile profile)
		{
			_dbContext.Add(profile);
			Save();

		}

		public void Save()
		{
			_dbContext.SaveChanges();
		}

		public void UpdateProfile(Profile profile)
		{
			_dbContext.Entry(profile).State = EntityState.Modified;
			Save();
		}
	}
}
