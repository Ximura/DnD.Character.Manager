using System.Collections.Generic;

namespace DnD.Character.Manager.Services.Contracts
{
	public interface IRaceRepository
	{
		IEnumerable<IRace> GetRaces();
		IRace GetRace(string name);
	}
}