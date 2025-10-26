using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class DarkhalisPro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(595);

			AIType = 595;
			Main.projFrames[projectile.type] = 28;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("DarkhalisPro");

		}

	}
}
