using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public abstract class Minion:TremorModProjectile
	{
		public override void AI()
		{
			CheckActive();
		}

		public abstract void CheckActive();

	}
}