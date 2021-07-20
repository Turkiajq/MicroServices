using HealthService.Models;
using HealthService.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;


namespace HealthService.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class HealthController : ControllerBase
	{
		private readonly IHealthRepository _healthRepository;

		public HealthController(IHealthRepository healthRepository)
		{
			_healthRepository = healthRepository;
		}

		// GET: api/<HealthController>
		[HttpGet]
		public IActionResult Get()
		{
			var listOfPresonalInfo = _healthRepository.GetAllPersonalInfo();
			return new OkObjectResult(listOfPresonalInfo);
		}

		// GET api/<HealthController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			var personalInfo = _healthRepository.GetPersonalInfoById(id);
			return new OkObjectResult(personalInfo);
		}

		// POST api/<HealthController>
		[HttpPost]
		public IActionResult Post([FromBody] PersonalInfo personalInfo)
		{
			using (var scope = new TransactionScope())
			{
				_healthRepository.InsertPersonalInfo(personalInfo);
				scope.Complete();
				return CreatedAtAction(nameof(Get), new { id = personalInfo.ProfileId }, personalInfo);
			}
		}

		// PUT api/<HealthController>/5
		[HttpPut("{id}")]
		public IActionResult Put([FromBody] PersonalInfo personalInfo)
		{
			if (personalInfo != null)
			{
				using (var scope = new TransactionScope())
				{
					_healthRepository.UpdatePersonalInfo(personalInfo);
					scope.Complete();
					return new OkResult();
				}
			}
			return new NoContentResult();
		}

		// DELETE api/<HealthController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_healthRepository.DeletePersonalInfo(id);
			return new OkResult();
		}
	}
}
