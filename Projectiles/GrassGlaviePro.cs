using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class GrassGlaviePro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(66);

			AIType = 66;
			projectile.tileCollide = false;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("GrassGlaviePro");

		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(2))
			{
				target.AddBuff(20, 180, false);
			}

		}

		public override void AI()
		{
			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 44, projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}
		}
	}
}
