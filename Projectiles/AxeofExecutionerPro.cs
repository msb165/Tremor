using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class AxeofExecutionerPro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(182);

			projectile.width = 29;
			projectile.height = 29;
			AIType = 182;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("AxeofExecutioner");

		}

	}
}
