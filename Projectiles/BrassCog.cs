using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class BrassCog:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(24);

			AIType = 24;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("BrassCog");

		}

	}
}
