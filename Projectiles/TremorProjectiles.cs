using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic.Blasts;
using Tremor.Projectiles.Alchemic.Bursts;

namespace Tremor.Projectiles
{
	public class TremorProjectiles : GlobalProjectile
	{

		public override void SetDefaults(Projectile projectile)
		{
			if (Main.gameMenu) return;

			if (projectile.minion && Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.ZephyrhornBuff>()) != -1)
			{
				projectile.scale = 1.5f;
				projectile.width *= (int)1.5f;
				projectile.height *= (int)1.5f;
			}

			if ((projectile.type != ModContent.ProjectileType<SparkingCloudPro>() || projectile.type != ModContent.ProjectileType<AlchemasterPoisonCloudPro>()) && (projectile.aiStyle == 92 || projectile.type == ModContent.ProjectileType<PurpleBurst>() || projectile.type == ModContent.ProjectileType<PurpleSkull>() || projectile.type == ModContent.ProjectileType<PurpleSkullburst>() || projectile.type == ModContent.ProjectileType<ShadowBurst>() || projectile.type == ModContent.ProjectileType<ShadowSkull>() || projectile.type == ModContent.ProjectileType<ShadowSkullburst>() || projectile.type == ModContent.ProjectileType<ManaSkull>() || projectile.type == ModContent.ProjectileType<ManaSkullburst>() || projectile.type == ModContent.ProjectileType<MoonBurst>() || projectile.type == ModContent.ProjectileType<MoonSkull>() || projectile.type == ModContent.ProjectileType<MoonSkullburst>() || projectile.type == ModContent.ProjectileType<PoisonBurst>() || projectile.type == ModContent.ProjectileType<PoisonSkull>() || projectile.type == ModContent.ProjectileType<PoisonSkullburst>() || projectile.type == ModContent.ProjectileType<HealingSkullburst>() || projectile.type == ModContent.ProjectileType<HealingSkull>() || projectile.type == ModContent.ProjectileType<HealingSkullburst>() || projectile.type == ModContent.ProjectileType<ManaBurst>() || projectile.type == ModContent.ProjectileType<GoldenBurst>() || projectile.type == ModContent.ProjectileType<GoldenSkull>() || projectile.type == ModContent.ProjectileType<GoldenSkullburst>() || projectile.type == ModContent.ProjectileType<HealingBurst>() || projectile.type == ModContent.ProjectileType<FierySkullburst>() || projectile.type == ModContent.ProjectileType<FrostBurst>() || projectile.type == ModContent.ProjectileType<FrostSkull>() || projectile.type == ModContent.ProjectileType<FrostSkullburst>() || projectile.type == ModContent.ProjectileType<BasicBurst>() || projectile.type == ModContent.ProjectileType<BasicSkull>() || projectile.type == ModContent.ProjectileType<BasicSkullburst>() || projectile.type == ModContent.ProjectileType<BoomBurst>() || projectile.type == ModContent.ProjectileType<BoomSkull>() || projectile.type == ModContent.ProjectileType<BoomSkullburst>() || projectile.type == ModContent.ProjectileType<ClusterBurst>() || projectile.type == ModContent.ProjectileType<ClusterSkull>() || projectile.type == ModContent.ProjectileType<ClusterSkullburst>() || projectile.type == ModContent.ProjectileType<CrystalBurst>() || projectile.type == ModContent.ProjectileType<CrystalSkull>() || projectile.type == ModContent.ProjectileType<FieryBurst>() || projectile.type == ModContent.ProjectileType<CrystalSkull>() || projectile.type == ModContent.ProjectileType<FierySkull>() || projectile.type == ModContent.ProjectileType<BoomBlast>() || projectile.type == ModContent.ProjectileType<CrystalBlast>() || projectile.type == ModContent.ProjectileType<FieryBlast>() || projectile.type == ModContent.ProjectileType<FrostBlast>() || projectile.type == ModContent.ProjectileType<GoldenBlast>() || projectile.type == ModContent.ProjectileType<HealingBlast>() || projectile.type == ModContent.ProjectileType<ManaBlast>() || projectile.type == ModContent.ProjectileType<MoonBlast>() || projectile.type == ModContent.ProjectileType<PlagueBlast>() || projectile.type == ModContent.ProjectileType<PoisonBlast>() || projectile.type == ModContent.ProjectileType<PurpleBlast>() || projectile.type == ModContent.ProjectileType<ShadowBlast>() || projectile.type == ModContent.ProjectileType<SparkingBlast>() || projectile.type == ModContent.ProjectileType<SparkingBallz>()) && Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.FlaskExpansionBuff>()) != -1)
			{
				projectile.scale = 1.2f;
				projectile.width *= (int)1.2f;
				projectile.height *= (int)1.2f;
			}
		}

		public override void AI(Projectile projectile)
		{
			if (projectile.aiStyle == 88 && projectile.knockBack == .5f || (projectile.knockBack >= .2f && projectile.knockBack < .5f))
			{
				projectile.hostile = false;
				projectile.friendly = true;
				projectile.DamageType = DamageClass.Magic;
				projectile.penetrate = -1;
				if ((projectile.knockBack >= .45f && projectile.knockBack < .5f) && projectile.oldVelocity != projectile.velocity && Main.rand.Next(0, 4) == 0)
				{
					projectile.knockBack -= .0125f;
					Vector2 vector83 = projectile.velocity.RotatedByRandom(.1f);
					Projectile.NewProjectile(null, projectile.Center.X, projectile.Center.Y, vector83.X, vector83.Y, projectile.type, projectile.damage, projectile.knockBack - .025f, projectile.owner, projectile.velocity.ToRotation(), projectile.ai[1]);
				}
			}
		}

		public override void OnHitNPC(Projectile projectile, NPC target, NPC.HitInfo hit, int damageDone)
		{
			if (projectile.aiStyle == 88 && (projectile.knockBack >= .2f && projectile.knockBack <= .5f))
			{
				target.immune[projectile.owner] = 6;
			}

			if ((projectile.type != ModContent.ProjectileType<SparkingCloudPro>() || projectile.type != ModContent.ProjectileType<AlchemasterPoisonCloudPro>()) && (projectile.aiStyle == 92 || projectile.type == ModContent.ProjectileType<PurpleBurst>() || projectile.type == ModContent.ProjectileType<PurpleSkull>() || projectile.type == ModContent.ProjectileType<PurpleSkullburst>() || projectile.type == ModContent.ProjectileType<ShadowBurst>() || projectile.type == ModContent.ProjectileType<ShadowSkull>() || projectile.type == ModContent.ProjectileType<ShadowSkullburst>() || projectile.type == ModContent.ProjectileType<ManaSkull>() || projectile.type == ModContent.ProjectileType<ManaSkullburst>() || projectile.type == ModContent.ProjectileType<MoonBurst>() || projectile.type == ModContent.ProjectileType<MoonSkull>() || projectile.type == ModContent.ProjectileType<MoonSkullburst>() || projectile.type == ModContent.ProjectileType<PoisonBurst>() || projectile.type == ModContent.ProjectileType<PoisonSkull>() || projectile.type == ModContent.ProjectileType<PoisonSkullburst>() || projectile.type == ModContent.ProjectileType<HealingSkullburst>() || projectile.type == ModContent.ProjectileType<HealingSkull>() || projectile.type == ModContent.ProjectileType<HealingSkullburst>() || projectile.type == ModContent.ProjectileType<ManaBurst>() || projectile.type == ModContent.ProjectileType<GoldenBurst>() || projectile.type == ModContent.ProjectileType<GoldenSkull>() || projectile.type == ModContent.ProjectileType<GoldenSkullburst>() || projectile.type == ModContent.ProjectileType<HealingBurst>() || projectile.type == ModContent.ProjectileType<FierySkullburst>() || projectile.type == ModContent.ProjectileType<FrostBurst>() || projectile.type == ModContent.ProjectileType<FrostSkull>() || projectile.type == ModContent.ProjectileType<FrostSkullburst>() || projectile.type == ModContent.ProjectileType<BasicBurst>() || projectile.type == ModContent.ProjectileType<BasicSkull>() || projectile.type == ModContent.ProjectileType<BasicSkullburst>() || projectile.type == ModContent.ProjectileType<BoomBurst>() || projectile.type == ModContent.ProjectileType<BoomSkull>() || projectile.type == ModContent.ProjectileType<BoomSkullburst>() || projectile.type == ModContent.ProjectileType<ClusterBurst>() || projectile.type == ModContent.ProjectileType<ClusterSkull>() || projectile.type == ModContent.ProjectileType<ClusterSkullburst>() || projectile.type == ModContent.ProjectileType<CrystalBurst>() || projectile.type == ModContent.ProjectileType<CrystalSkull>() || projectile.type == ModContent.ProjectileType<FieryBurst>() || projectile.type == ModContent.ProjectileType<CrystalSkull>() || projectile.type == ModContent.ProjectileType<FierySkull>() || projectile.type == ModContent.ProjectileType<BoomBlast>() || projectile.type == ModContent.ProjectileType<CrystalBlast>() || projectile.type == ModContent.ProjectileType<FieryBlast>() || projectile.type == ModContent.ProjectileType<FrostBlast>() || projectile.type == ModContent.ProjectileType<GoldenBlast>() || projectile.type == ModContent.ProjectileType<HealingBlast>() || projectile.type == ModContent.ProjectileType<ManaBlast>() || projectile.type == ModContent.ProjectileType<MoonBlast>() || projectile.type == ModContent.ProjectileType<PlagueBlast>() || projectile.type == ModContent.ProjectileType<PoisonBlast>() || projectile.type == ModContent.ProjectileType<PurpleBlast>() || projectile.type == ModContent.ProjectileType<ShadowBlast>() || projectile.type == ModContent.ProjectileType<SparkingBlast>() || projectile.type == ModContent.ProjectileType<SparkingBallz>()) && Main.LocalPlayer.active && Main.LocalPlayer.FindBuffIndex(ModContent.BuffType<Buffs.CursedCloudBuff>()) != -1)
			{
				target.AddBuff(31, 360, false);
			}
		}
		public override bool? CanHitNPC(Projectile projectile, NPC target)
		{
			if (projectile.aiStyle == 88 && ((projectile.knockBack == .5f || projectile.knockBack == .4f) || (projectile.knockBack >= .4f && projectile.knockBack < .5f)) && target.immune[projectile.owner] > 0)
			{
				return false;
			}
			return null;
		}

	}
}

