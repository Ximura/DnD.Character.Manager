using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DnD.Character.Manager.Services.Contracts;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DnD.Character.Manager.Controllers
{
	[Route("api/[controller]")]
	public class RaceController : Controller
	{
		IRaceRepository raceRepository;

		public RaceController(IRaceRepository raceRepository)
		{
			this.raceRepository = raceRepository;
		}

		// GET: api/values
		[HttpGet]
		public IEnumerable<IRace> Get()
		{
			return raceRepository.GetRaces();
		}

		// GET api/values/5
		[HttpGet("{name}")]
		public IRace Get(string name)
		{
			return raceRepository.GetRace(name);
		}
	}
}
