using System;
using System.Collections.Generic;
using DnD.Character.Manager.Services.Contracts;

namespace DnD.Character.Manager.Services
{
	public class InMemoryRaceRepository : IRaceRepository
	{
		private readonly Dictionary<string, IRace> races;

		public InMemoryRaceRepository()
		{
			races = new Dictionary<string, IRace>();
		}


		public IEnumerable<IRace> GetRaces()
		{
			return races.Values;
		}

		public IRace GetRace(string name)
		{
			IRace race;
			races.TryGetValue(name, out race);
			return race;
		}
	}
}
