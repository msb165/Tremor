using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class LightningBoltPro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(443);

			aiType = 443;
			projectile.DamageType = DamageClass.Magic;

			projectile.timeLeft = 500;
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("LightningBoltPro");

		}

	}
}
