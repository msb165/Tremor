using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class TitaniumDiscPro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(106);

			AIType = 106;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TitaniumDiscPro");

		}

	}
}
