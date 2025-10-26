using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class TwilightKnifePro:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 1;
			projectile.height = 1;
			projectile.friendly = true;
			projectile.aiStyle = 1;
			projectile.timeLeft = 1200;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Twilight Knife Pro");

		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 27, projectile.oldVelocity.X * 0.7f, projectile.oldVelocity.Y * 0.7f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item1, projectile.position);
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}
}
