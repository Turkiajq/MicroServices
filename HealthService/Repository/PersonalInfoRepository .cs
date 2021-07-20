using HealthService.DbContexts;
using HealthService.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthService.Repository
{
	public class PersonalInfoRepository : IHealthRepository
	{
		private readonly HealthDbContext _dbContext;

		public PersonalInfoRepository(HealthDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public void DeletePersonalInfo(int ProfileId)
		{
			var profile = _dbContext.PersonalInfo.Find(ProfileId);
			_dbContext.PersonalInfo.Remove(profile);
			Save();
		}

		public IEnumerable<PersonalInfo> GetAllPersonalInfo()
		{
			return _dbContext.PersonalInfo.ToList();
		}

		public PersonalInfo GetPersonalInfoById(int ProfileId)
		{
			return _dbContext.PersonalInfo.Find(ProfileId);
		}

		public void InsertPersonalInfo(PersonalInfo personalInfo)
		{
			_dbContext.Add(personalInfo);
			Save();
		}

		public void Save()
		{
			_dbContext.SaveChanges();
		}

		public void UpdatePersonalInfo(PersonalInfo personalInfo)
		{
			_dbContext.Entry(personalInfo).State = EntityState.Modified;
			Save();
		}
	}
}
