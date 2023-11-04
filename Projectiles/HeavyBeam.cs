using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class HeavyBeam:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(455);

			AIType = 455;
			projectile.width = 16;
			projectile.height = 16;
			projectile.timeLeft = 2;
			projectile.penetrate = -1;
			projectile.friendly = true;
			projectile.DamageType = DamageClass.Magic;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.alpha = 100;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Beam");

		}

	}
}
