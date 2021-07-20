using HealthService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthService.Repository
{
	public interface IHealthRepository
	{
		IEnumerable<PersonalInfo> GetAllPersonalInfo();
		PersonalInfo GetPersonalInfoById(int ProfileId);
		void InsertPersonalInfo(PersonalInfo personalInfo);
		void UpdatePersonalInfo(PersonalInfo personalInfo);
		void DeletePersonalInfo(int ProfileId);
		void Save();
	}
}
