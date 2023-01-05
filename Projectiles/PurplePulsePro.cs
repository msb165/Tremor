using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Audio;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class PurplePulsePro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(436);

			aiType = 436;
			projectile.width = 90;
			projectile.height = 34;
			projectile.hostile = true;
			projectile.timeLeft = 500;
			projectile.light = 0.8f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault(nameof(PurplePulsePro));
		}

		public override void Kill(int timeLeft)
		{
			SoundEngine.PlaySound(SoundID.Item62, projectile.position);
			//if (projectile.owner == Main.myPlayer)
			//{
			//	Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
			//	value17.Normalize();
			//	value17 *= Main.rand.Next(10, 201) * 0.01f;
			//	Projectile.NewProjectile(null, projectile.position, value17, ModContent.ProjectileType<PurpleBoomPro>(), projectile.damage, 1f, projectile.owner, 0f, Main.rand.Next(-45, 1));
			//}
		}

		public override void AI()
		{
			if (projectile.localAI[0] == 0f)
			{
				Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item91, projectile.position);
			}
			projectile.localAI[0] += 1f;
			if (projectile.localAI[0] > 3f)
			{
				int num90 = 1;
				if (projectile.localAI[0] > 5f)
				{
					num90 = 2;
				}
				for (int num91 = 0; num91 < num90; num91++)
				{
					Dust dust = Dust.NewDustDirect(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width, projectile.height, 27, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.1f, 100, default(Color), 0.4f);
					dust.noGravity = true;
					dust.velocity *= 0.3f;
					dust.noLight = true;
				}
				if (projectile.wet && !projectile.lavaWet)
				{
					projectile.Kill();
				}
			}
		}

		public override bool CanHitPlayer(Player target)
		{
			return true;
		}

	}
}
