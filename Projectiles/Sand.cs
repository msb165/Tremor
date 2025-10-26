using System;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class Sand:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 2;
			projectile.height = 2;
			projectile.friendly = true;
			projectile.aiStyle = 0;
			projectile.timeLeft = 1200;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sand");

		}

		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 19, projectile.oldVelocity.X * 0.1f, projectile.oldVelocity.Y * 0.1f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Dig, projectile.position);//Variant 0
		}
	}
}
