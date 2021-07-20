using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthService.Models
{
	public class PersonalInfo
	{
		public int Id { get; set; }
		public int ProfileId { get; set; }
		public string BloodType { get; set; }
		public int Height { get; set; }
		public int Weight { get; set; }
		public int FitnessLevel { get; set; }
	}
}
