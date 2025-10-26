using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class ElectricBolt:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.friendly = true;
			projectile.width = 36;
			projectile.height = 16;
			projectile.aiStyle = 0;
			Main.projFrames[projectile.type] = 4;
			projectile.timeLeft = 1200;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Electric Bolt");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}

		public override void AI()
		{
			int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 136, default(Color), 0.9f);
			Main.dust[dust].noGravity = true;

			if (projectile.frameCounter < 5)
				projectile.frame = 0;
			else if (projectile.frameCounter >= 5 && projectile.frameCounter < 10)
				projectile.frame = 1;
			else if (projectile.frameCounter >= 10 && projectile.frameCounter < 15)
				projectile.frame = 2;
			else if (projectile.frameCounter >= 15 && projectile.frameCounter < 20)
				projectile.frame = 3;
			else
				projectile.frameCounter = 0;
			projectile.frameCounter++;
		}

		public override void OnKill(int timeLeft)
		{
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

	}
}
