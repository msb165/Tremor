using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class PlatinumKunai:TremorModProjectile
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
			// DisplayName.SetDefault("Platinum Kunai");

		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 73, projectile.oldVelocity.X * 0.7f, projectile.oldVelocity.Y * 0.7f);
			}
			Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[0], projectile.position);//Variant 1
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 0.75f;
		}
	}
}
