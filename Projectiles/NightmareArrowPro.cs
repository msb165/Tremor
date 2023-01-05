using Terraria;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	//ported from my tAPI mod because I don't want to make artwork
	public class NightmareArrowPro:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 16;
			projectile.height = 40;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -2;
			projectile.tileCollide = true;
			projectile.DamageType = DamageClass.Melee;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare Arrow");

		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (Main.rand.NextBool(2))
			{
				target.AddBuff(ModContent.BuffType<Buffs.DeathFear>(), 480, false);
			}
		}

		public override void Kill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				int dust = Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Dusts.NightmareFlame>(), projectile.oldVelocity.X * 0.1f, projectile.oldVelocity.Y * 0.1f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Dig, projectile.position);//Variant 0
		}

		public override void OnHitPvp(Player target, int damage, bool crit)
		{
			if (Main.rand.NextBool(2))
			{
				target.AddBuff(ModContent.BuffType<Buffs.DeathFear>(), 480, false);
			}
		}
	}
}
