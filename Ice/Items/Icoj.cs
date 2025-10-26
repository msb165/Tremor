using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class Icoj:TremorModProjectile
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ice Proj");
		}
		float rotationProj;
		public override void SetDefaults()
		{
			projectile.width = 92;
			projectile.height = 102;
			projectile.aiStyle = -1;
			projectile.friendly = true;
			projectile.DamageType = DamageClass.Magic;
			projectile.penetrate = -1;
			projectile.timeLeft = 3600;
			//projectile.alpha = 255;
			//projectile.light = 0.5f;
			projectile.tileCollide = false;
			projectile.extraUpdates = 1;
			//Main.projFrames[projectile.type] = 7;
			//ProjectileID.Sets.TrailCacheLength[projectile.type] = 7;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
			//AIType = ProjectileID.Bullet;
		}

		int timer;
		public override void AI()
		{
			timer++;
			rotationProj += 0.097f;
			projectile.rotation = rotationProj;
			projectile.velocity.X = 0f;
			projectile.velocity.Y = 0f;

			if (timer >= 350)
			{
				projectile.alpha++;
				projectile.alpha++;
			}

			if (projectile.alpha >= 255)
			{
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, -7, 0, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, 7, 0, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, 0, 7, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, 0, -7, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, -7, -7, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, 7, -7, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, -7, 7, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, 7, 7, 119, projectile.damage, 0, Main.myPlayer, 0f, 0f);
				projectile.Kill();
			}
		}
	}
}