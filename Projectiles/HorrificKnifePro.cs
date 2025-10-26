using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Projectiles
{
	public class HorrificKnifePro:TremorModProjectile
	{
		public override void SetDefaults()
		{

			projectile.width = 14;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.aiStyle = 1;
			projectile.timeLeft = 1200;
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Horrific Dagger");

		}

		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (Main.rand.NextBool())
			{
				target.AddBuff(ModContent.BuffType<Buffs.DeathFear>(), 480, false);
			}
		}

		public override void OnKill(int timeLeft)
		{
			for (int k = 0; k < 5; k++)
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, ModContent.DustType<Dusts.NightmareFlame>(), projectile.oldVelocity.X * 0.5f, projectile.oldVelocity.Y * 2f, 100, default(Color), 2f);
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Dig, projectile.position);//Variant 0
		}

		public override void OnHitPlayer(Player target, Player.HurtInfo hurtInfo)
		{
			if (Main.rand.NextBool(3))
			{
				target.AddBuff(ModContent.BuffType<Buffs.DeathFear>(), 480, false);
			}
		}
	}
}
