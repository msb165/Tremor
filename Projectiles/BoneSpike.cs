using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class BoneSpike:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 22;
			projectile.height = 22;
			projectile.aiStyle = 14;
			projectile.friendly = true;
			projectile.DamageType = DamageClass.Ranged;
			projectile.penetrate = 5;
			projectile.timeLeft = 1500;
			projectile.extraUpdates = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bone Spike");

		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 40; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, 26, projectile.oldVelocity.X * 0.7f, projectile.oldVelocity.Y * 0.7f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Dig, projectile.position);//Variant 0
		}
	}
}
