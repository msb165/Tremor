using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class TomatoPro:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 13;
			projectile.height = 15;
			projectile.friendly = true;
			projectile.aiStyle = 2;
			projectile.timeLeft = 1200;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tomato Pro");

		}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 5, projectile.oldVelocity.X * 0.1f, projectile.oldVelocity.Y * 0.1f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Dig, projectile.position);//Variant 0
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}
}
