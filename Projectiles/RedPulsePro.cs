using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class RedPulsePro : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(436);

			aiType = 436;
			projectile.hostile = true;
			projectile.width = 90;
			projectile.height = 34;
			projectile.timeLeft = 500;
			projectile.light = 0.8f;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("RedPulsePro");

		}

		public override void Kill(int timeLeft)
		{
			Main.PlaySound(2, projectile.position, 62);
			//if (projectile.owner == Main.myPlayer)
			//{
			//	Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
			//	value17.Normalize();
			//	value17 *= Main.rand.Next(10, 201) * 0.01f;
			//	Projectile.NewProjectile(projectile.position, value17, ModContent.ProjectileType<RedBoomPro>(), projectile.damage, 1f, projectile.owner, 0f, Main.rand.Next(-45, 1));
			//}
		}

		public override void AI()
		{
			if (projectile.localAI[0] == 0f)
			{
				Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 91);
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
					Dust dust = Dust.NewDustDirect(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width, projectile.height, 60, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.1f, 100, default(Color), 0.4f);
					dust.noGravity = true;
					dust.velocity *= 0.3f;
					dust.noLight = false;
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
