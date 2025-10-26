using System;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class CyberRingPro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(348);

			projectile.width = 90;
			projectile.height = 90;
			AIType = 348;
			projectile.hostile = true;
			projectile.timeLeft = 500;
			projectile.light = 0.8f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("CyberRingPro");

		}

		public override void AI()
		{
			if (projectile.ai[1] == 0f)
			{
				projectile.ai[1] = 1f;
				Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item67, projectile.position);
			}
			projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
			if (Main.rand.NextBool())
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 60, projectile.velocity.X * 0.9f, projectile.velocity.Y * 0.9f);
			}
		}

	}
}
