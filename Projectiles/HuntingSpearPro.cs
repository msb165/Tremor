using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class HuntingSpearPro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(66);

			AIType = 66;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("HuntingSpearPro");

		}

	}
}
