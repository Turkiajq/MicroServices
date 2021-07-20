using Microsoft.AspNetCore.Mvc;
using ProfileService.Models;
using ProfileService.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProfileService.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class ProfileController : ControllerBase
	{
		private readonly IProfileRepository _profileRepository;

		public ProfileController(IProfileRepository profileRepository)
		{
			_profileRepository = profileRepository;
		}

		// GET: api/<ProfileController>
		[HttpGet]
		public IActionResult Get()
		{
			var profiles = _profileRepository.GetProfiles();
			return new OkObjectResult(profiles);
		}

		// GET api/<ProfileController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var profile = _profileRepository.GetProfileById(id);
			return new OkObjectResult(profile);
		}

		// POST api/<ProfileController>
		[HttpPost]
		public IActionResult Post([FromBody] Profile profile)
		{
			using (var scope = new TransactionScope())
			{
				_profileRepository.InsertProfile(profile);
				scope.Complete();
				return CreatedAtAction(nameof(Get), new { id = profile.Id }, profile);
			}
		}

		// PUT api/<ProfileController>/5
		[HttpPut("{id}")]
		public IActionResult Put([FromBody] Profile profile)
		{
			if (profile != null)
			{
				using (var scope = new TransactionScope())
				{
					_profileRepository.UpdateProfile(profile);
					scope.Complete();
					return new OkResult();
				}
			}
			return new NoContentResult();
		}

		// DELETE api/<ProfileController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_profileRepository.DeleteProfile(id);
			return new OkResult();
		}
	}
}
