using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Buffs;

namespace Tremor.NPCs.Bosses.NovaPillar.Projectiles
{
	public class NovaFlask_ProjBall:TremorModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.SpikyBall);
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.timeLeft = 180;
			projectile.width = 20;
			Main.projFrames[projectile.type] = 3;
			projectile.height = 20;
			try
			{
				projectile.scale = Main.LocalPlayer.HasBuffSafe(ModContent.BuffType<BouncingCasingBuff>()) ? 3:1;
			}
			catch{projectile.scale = 1;}
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void AI()
		{
			projectile.frameCounter++;
			if (projectile.frameCounter > 3)
			{
				projectile.frame++;
				projectile.frameCounter = 0;
			}
			if (projectile.frame >= 3)
			{
				projectile.frame = 0;
			}
			for (int i = 0; i < Main.dust.Length; i++)
			{
				if ((/*Main.dust[i].type == DustID.Fire || */Main.dust[i].type == DustID.Smoke || Main.dust[i].type == DustID.Torch) && projectile.Distance(Main.dust[i].position) < 150f)
				{
					Main.dust[i].scale /= 1000000f;
					Main.dust[i].active = false;
				}
			}
		}

		public override void OnKill(int timeLeft)
		{
			Player player = Main.player[projectile.owner];
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			Projectile.NewProjectile(null, projectile.Center.X, projectile.Center.Y, 0, 0, ModContent.ProjectileType<NovaFlask_ProjFire>(), projectile.damage - 30, 0, Main.myPlayer);
			Projectile.NewProjectile(null, projectile.Center.X, projectile.Center.Y, 0, 0, ModContent.ProjectileType<NovaFlask_ProjFire>(), projectile.damage - 30, 0, Main.myPlayer);

			if (projectile.owner == Main.myPlayer)
			{
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
				}
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.25f, projectile.owner);
					Main.projectile[a].scale = 1.25f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 32, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 32, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 32, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 32, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
				}
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.25f, projectile.owner);
					Main.projectile[a].scale = 1.25f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 30, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 30, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[f].scale = 0.7f;
					int g = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[g].scale = 0.7f;
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 50, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[h].scale = 0.7f;
					int i = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 50, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[i].scale = 0.7f;
					int j = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[j].scale = 0.8f;
					int k = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[k].scale = 0.8f;
					int l = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[l].scale = 0.8f;
					int m = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[m].scale = 0.8f;
				}
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y + 40, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y - 40, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y - 40, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()) && !modPlayer.pyro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()) && !modPlayer.pyro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()) && !modPlayer.pyro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X + 100, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X - 100, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item42, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 20, projectile.position.Y, +5, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 20, projectile.position.Y, -5, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item42, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 10, projectile.position.Y - 10, +6, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 10, projectile.position.Y - 10, -6, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 10, +4, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y + 10, -4, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item42, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 10, projectile.position.Y - 15, +6, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 10, projectile.position.Y - 15, -6, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y, +5, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y, -5, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y + 15, +4, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y + 15, -4, 0, ModContent.ProjectileType<NovaSkull>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int z = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[z].scale = 1.25f;
					int a = Projectile.NewProjectile(null, projectile.position.X + 25, projectile.position.Y, 4, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 25, projectile.position.Y, -4, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 25, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 25, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 20, projectile.position.Y + 20, 4, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.8f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 20, projectile.position.Y + 20, -4, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.8f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 20, projectile.position.Y - 20, 4, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.8f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 20, projectile.position.Y - 20, -4, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.8f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int z = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[z].scale = 1.25f;
					int a = Projectile.NewProjectile(null, projectile.position.X + 65, projectile.position.Y, 3, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 65, projectile.position.Y, -3, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 35, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 35, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 1.2f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 1.2f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 1.2f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 1.2f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int z = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[z].scale = 1.25f;
					int a = Projectile.NewProjectile(null, projectile.position.X + 65, projectile.position.Y, 3, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 65, projectile.position.Y, -3, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 35, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 35, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.8f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.8f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.8f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.8f;
					int i = Projectile.NewProjectile(null, projectile.position.X + 80, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[i].scale = 0.6f;
					int k = Projectile.NewProjectile(null, projectile.position.X - 80, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[k].scale = 0.6f;
					int l = Projectile.NewProjectile(null, projectile.position.X + 80, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[l].scale = 0.6f;
					int m = Projectile.NewProjectile(null, projectile.position.X - 80, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[m].scale = 0.6f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[d].scale = 1.5f;
					int e = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 3, 3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -3, 3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 3, -3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -3, -3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[d].scale = 1.5f;
					int e = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 2, 3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.75f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -2, 3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.75f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 2, -3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.75f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -2, -3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.75f;
					int i = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 3, 2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[i].scale = 0.75f;
					int j = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -3, 2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[j].scale = 0.75f;
					int k = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 3, -2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[k].scale = 0.75f;
					int l = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -3, -2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[l].scale = 0.75f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<NovaBlast>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[d].scale = 1.5f;
					int e = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 2, 4, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.65f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -2, 4, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.65f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 2, -4, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.65f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -2, -4, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.65f;
					int i = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 4, 2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[i].scale = 0.65f;
					int j = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -4, 2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[j].scale = 0.65f;
					int k = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 4, -2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[k].scale = 0.65f;
					int l = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -4, -2, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[l].scale = 0.65f;
					int m = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 3, 3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[m].scale = 0.7f;
					int n = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -3, 3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[n].scale = 0.7f;
					int o = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 3, -3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[o].scale = 0.7f;
					int p = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -3, -3, ModContent.ProjectileType<NovaSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[p].scale = 0.7f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y, -2, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y, +2, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y, -2, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y, +2, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, -3, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, +3, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y, -2, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y, +2, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, -3, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, +3, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X - 80, projectile.position.Y, -4, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 80, projectile.position.Y, +4, 0, ModContent.ProjectileType<NovaBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 4, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, -4, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, -4, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 4, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, -4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 4, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 6, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, -6, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 6, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, -6, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, -6, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 6, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, -6, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 6, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 8, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, -8, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 8, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, -8, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, -8, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 8, 0, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, -8, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 8, ModContent.ProjectileType<NovaSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
				}
			}
		}
		public override void OnHitNPC(NPC target, NPC.HitInfo hit, int damageDone)
		{
			projectile.Kill();
		}

		public override bool? CanDamage()
		{
			return false;
		}

		public override void OnHitPlayer(Player target, Player.HurtInfo info)
		{
			//info.Damage = 1;
		}
	}
}