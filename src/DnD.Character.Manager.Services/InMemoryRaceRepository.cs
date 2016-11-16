using System;
using System.Collections.Generic;
using DnD.Character.Manager.Services.Contracts;
using Newtonsoft.Json;
using System.IO;

namespace DnD.Character.Manager.Services
{
	public class InMemoryRaceRepository : IRaceRepository
	{
		private readonly Dictionary<string, IRace> races;
		private readonly string filename = "data/races.json";

		public InMemoryRaceRepository()
		{
			races = new Dictionary<string, IRace>();

			//var res = JsonConvert.DeserializeObject<Race>(File.ReadAllText(filename));

			races.Add("elf", new Race("elf"));
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
