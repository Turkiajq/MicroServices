using ProfileService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.Repository
{
	public interface IProfileRepository
	{
		IEnumerable<Profile> GetProfiles();
		Profile GetProfileById(int ProfileId);
		void InsertProfile(Profile profile);
		void UpdateProfile(Profile profile);
		void DeleteProfile(int ProfileId);
		void Save();

	}
}
