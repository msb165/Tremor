using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic.Blasts;

namespace Tremor.Projectiles
{
	public class PlaguePro:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(566);

			AIType = 566;
			projectile.tileCollide = false;
			Main.projFrames[projectile.type] = 4;
			projectile.width = 20;
			projectile.height = 16;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("PlaguePro");

		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void OnKill(int timeLeft)
		{
			int ses = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<PlagueBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
			Main.projectile[ses].scale = projectile.scale;
		}

		public override void AI()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter > 2)
			{
				projectile.frame++;
				projectile.frameCounter = 0;
			}
			if (projectile.frame >= 4)
			{ projectile.frame = 0; }

		}
	}
}
