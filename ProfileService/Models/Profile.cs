using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileService.Models
{
	public class Profile
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhonrNumber { get; set; }
		public int ScoreId { get; set; }

	}
}
