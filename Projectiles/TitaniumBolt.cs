using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class TitaniumBolt:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 18;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.DamageType = DamageClass.Magic;
			projectile.penetrate = 6;
			projectile.aiStyle = 1;
			projectile.timeLeft = 600;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TitaniumBolt");

		}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 0, projectile.oldVelocity.X * 0.1f, projectile.oldVelocity.Y * 0.1f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Dig, projectile.position);//Variant 0
		}

	}
}
