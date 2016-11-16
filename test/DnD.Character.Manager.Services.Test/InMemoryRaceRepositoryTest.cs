using DnD.Character.Manager.Services.Contracts;
using NUnit.Framework;

namespace DnD.Character.Manager.Services.Test
{
	[TestFixture]
	public class InMemoryRaceRepositoryTest
	{
		private IRaceRepository raceRepository;

		[SetUp]
		public void Setup()
		{
			raceRepository = new InMemoryRaceRepository();
		}

		[Test]
		public void ShouldReturnRaces()
		{
			var races = raceRepository.GetRaces();
			Assert.IsEmpty(races);
		}

		//[TestCase("elf")]
		public void ShouldReturnCorrectRace(string name)
		{
			var race = raceRepository.GetRace(name);
			Assert.AreEqual(race.Name, name);
		}

		[TestCase("elf_1")]
		public void ShouldReturnNullForInCorrectRace(string name)
		{
			var race = raceRepository.GetRace(name);
			Assert.IsNull(race);
		}
	}
}
