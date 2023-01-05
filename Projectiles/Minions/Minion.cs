using Terraria.ModLoader;

namespace Tremor.Projectiles.Minions
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