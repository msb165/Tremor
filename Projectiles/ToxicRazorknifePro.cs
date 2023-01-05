using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	//ported from my tAPI mod because I don't want to make artwork
	public class ToxicRazorknifePro:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 14;
			projectile.height = 42;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -2;
			projectile.tileCollide = true;
			projectile.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toxic Razorknife Pro");

		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.NextBool(6))
			{
				target.AddBuff(BuffID.Poisoned, 280, false);
			}
		}

		public override void OnHitPvp(Player target, int damage, bool crit)
		{
			if (Main.rand.NextBool(6))
			{
				target.AddBuff(BuffID.Poisoned, 280, false);
			}
		}
	}
}
