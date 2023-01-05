using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class RavenFeather:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 4;
			projectile.height = 4;
			projectile.friendly = true;
			projectile.DamageType = DamageClass.Magic;
			projectile.penetrate = -1;
			projectile.aiStyle = 1;
			projectile.timeLeft = 600;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Raven Feather");

		}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 1, projectile.oldVelocity.X * 0.1f, projectile.oldVelocity.Y * 0.1f);
			}
			Terraria.Audio.SoundEngine.PlaySound(SoundID.SoundByIndex[6], projectile.position);//Variant 0
		}

	}
}
