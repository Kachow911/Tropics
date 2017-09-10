using Terraria.ModLoader;

namespace Tropics
{
	class Tropics : Mod
	{
		public Tropics()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
