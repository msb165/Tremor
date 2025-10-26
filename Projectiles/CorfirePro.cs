using System;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class CorfirePro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(553);

			projectile.width = 16;
			projectile.height = 16;
			projectile.friendly = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("CorfirePro");

		}

		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
			if (Main.rand.NextBool())
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 74, projectile.velocity.X * 0.9f, projectile.velocity.Y * 0.9f);
			}
		}
		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool(2))
			{
				target.AddBuff(39, 280, false);
			}
		}

		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			if (Main.rand.NextBool(2))
			{
				target.AddBuff(39, 280, false);
			}
		}
	}
}
