using System.Linq;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles.Alchemic
{
	public class HealingCloudPro : AlchemistProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.DamageType = DamageClass.Magic;
			projectile.penetrate = 8;
			projectile.aiStyle = 92;
			projectile.friendly = true;
			projectile.timeLeft = 600;
		}

		public override void AI()
		{
			projectile.rotation = 0f;
		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.LocalPlayer.HasBuffSafe(ModContent.BuffType<Buffs.ConcentratedTinctureBuff>()))
			{
				int newLife = 2;
				Main.player[projectile.owner].statLife += newLife;
				Main.player[projectile.owner].HealEffect(newLife);
			}
			else
			{
				int newLife = 1;
				Main.player[projectile.owner].statLife += newLife;
				Main.player[projectile.owner].HealEffect(newLife);
			}
		}

	}
}