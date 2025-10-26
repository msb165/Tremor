using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class AlchemasterPoisonCloudPro:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 40;
			projectile.height = 40;
			projectile.DamageType = DamageClass.Magic;
			projectile.penetrate = 8;
			projectile.aiStyle = 92;
			projectile.hostile = true;
			projectile.timeLeft = 600;
			projectile.light = 1.0f;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("PoisonCloudPro");

		}

		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			if (Main.rand.NextBool())
			{
				target.AddBuff(20, 180, false);
			}
		}

	}
}
