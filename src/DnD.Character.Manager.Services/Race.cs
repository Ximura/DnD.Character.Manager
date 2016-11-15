using DnD.Character.Manager.Services.Contracts;

namespace DnD.Character.Manager.Services
{
	internal class Race : IRace
	{
		public Race(string name)
		{
			Name = name;
		}

		public string Name { get; }
	}
}