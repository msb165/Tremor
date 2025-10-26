using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Projectiles.Alchemic.Blasts;
using Tremor.Projectiles.Alchemic.Bursts;

namespace Tremor.Projectiles.Alchemic
{
	public class BoomFlaskPro : AlchemistProjectile
	{
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 2;
		}

		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 28;
			projectile.friendly = true;
			projectile.penetrate = 1;
			// todo: move
			if (Main.LocalPlayer.HasBuffSafe(ModContent.BuffType<Buffs.BouncingCasingBuff>()))
			{
				projectile.penetrate = 3;
			}
			else
				projectile.penetrate = 1;
			projectile.aiStyle = 2;
			projectile.timeLeft = 1200;
		}

		public override void AI()
		{
			if (Main.LocalPlayer.HasBuffSafe(ModContent.BuffType<Buffs.TheCadenceBuff>()))
			{
				int[] array = new int[20];
				int num428 = 0;
				float num429 = 495f;
				bool flag14 = false;
				for (int num430 = 0; num430 < 200; num430++)
				{
					if (Main.npc[num430].CanBeChasedBy(projectile, false))
					{
						float num431 = Main.npc[num430].position.X + Main.npc[num430].width / 2;
						float num432 = Main.npc[num430].position.Y + Main.npc[num430].height / 2;
						float num433 = Math.Abs(projectile.position.X + projectile.width / 2 - num431) + Math.Abs(projectile.position.Y + projectile.height / 2 - num432);
						if (num433 < num429 && Collision.CanHit(projectile.Center, 1, 1, Main.npc[num430].Center, 1, 1))
						{
							if (num428 < 20)
							{
								array[num428] = num430;
								num428++;
							}
							flag14 = true;
						}
					}
				}
				if (flag14)
				{
					int num434 = Main.rand.Next(num428);
					num434 = array[num434];
					float num435 = Main.npc[num434].position.X + Main.npc[num434].width / 2;
					float num436 = Main.npc[num434].position.Y + Main.npc[num434].height / 2;
					projectile.localAI[0] += 1f;
					if (projectile.localAI[0] > 8f)
					{
						projectile.localAI[0] = 0f;
						float num437 = 6f;
						Vector2 value10 = new Vector2(projectile.position.X + projectile.width * 0.5f, projectile.position.Y + projectile.height * 0.5f);
						value10 += projectile.velocity * 4f;
						float num438 = num435 - value10.X;
						float num439 = num436 - value10.Y;
						float num440 = (float)Math.Sqrt(num438 * num438 + num439 * num439);
						num440 = num437 / num440;
						num438 *= num440;
						num439 *= num440;
						if (Main.rand.NextBool(2))
						{
							Projectile.NewProjectile(null, value10.X, value10.Y, num438, num439, ModContent.ProjectileType<TheCadenceProj>(), projectile.damage, projectile.knockBack, projectile.owner, 0f, 0f);
						}
					}
				}
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (Main.LocalPlayer.HasBuffSafe(ModContent.BuffType<Buffs.BouncingCasingBuff>()))
			{
				projectile.penetrate--;
				if (projectile.penetrate <= 0)
				{
					projectile.Kill();
				}
				else
				{
					if (projectile.velocity.X != oldVelocity.X)
					{
						projectile.velocity.X = -oldVelocity.X;
					}
					if (projectile.velocity.Y != oldVelocity.Y)
					{
						projectile.velocity.Y = -oldVelocity.Y;
					}
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item10, projectile.position);
				}
			}
			else
			{
				projectile.Kill();
			}

			return false;
		}

		public override void OnKill(int timeLeft)
		{
			Player player = Main.player[projectile.owner];

			if (player.HasBuffSafe(ModContent.BuffType<Buffs.DesertEmperorSetBuff>()))
			{
				int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<FlaskWasp>(), projectile.damage * 2, 1.5f, projectile.owner);
				int b = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<FlaskWasp>(), projectile.damage * 2, 1.5f, projectile.owner);
			}

			MPlayer modPlayer = player.GetModPlayer<MPlayer>();

			if (player.HasBuffSafe(ModContent.BuffType<Buffs.BrassChipBuff>()))
			{
				for (int i = 0; i < 5; i++)
				{
					Vector2 vector2 = new Vector2(player.position.X + 75f * (float)Math.Cos(12), player.position.Y + 1075f * (float)Math.Sin(12));
					Vector2 Velocity = Helper.VelocityToPoint(vector2, Helper.RandomPointInArea(new Vector2(projectile.Center.X - 10, projectile.Center.Y - 10), new Vector2(projectile.Center.X + 20, projectile.Center.Y + 20)), 24);
					int a = Projectile.NewProjectile(null, vector2.X, vector2.Y, Velocity.X, Velocity.Y, 134, projectile.damage, 1f);
					Main.projectile[a].friendly = true;
				}
			}
			if (player.HasBuffSafe(ModContent.BuffType<Buffs.ChaosElementBuff>()))
			{
				int num220 = Main.rand.Next(3, 6);
				for (int num221 = 0; num221 < num220; num221++)
				{
					Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
					value17.Normalize();
					value17 *= Main.rand.Next(10, 201) * 0.01f;
					Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, value17.X, value17.Y, ModContent.ProjectileType<Shatter1>(), projectile.damage, 1f, projectile.owner, 0f, Main.rand.Next(-45, 1));
				}
			}
			Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
			projectile.position.X = projectile.position.X + projectile.width / 2;
			projectile.position.Y = projectile.position.Y + projectile.height / 2;
			projectile.width = 80;
			projectile.height = 80;
			projectile.position.X = projectile.position.X - projectile.width / 2;
			projectile.position.Y = projectile.position.Y - projectile.height / 2;
			for (int num628 = 0; num628 < 40; num628++)
			{
				int num629 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 31, 0f, 0f, 100, default(Color), 2f);
				Main.dust[num629].velocity *= 3f;
				if (Main.rand.NextBool(2))
				{
					Main.dust[num629].scale = 0.5f;
					Main.dust[num629].fadeIn = 1f + Main.rand.Next(10) * 0.1f;
				}
			}
			for (int num630 = 0; num630 < 70; num630++)
			{
				int num631 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 3f);
				Main.dust[num631].noGravity = true;
				Main.dust[num631].velocity *= 5f;
				num631 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, 6, 0f, 0f, 100, default(Color), 2f);
				Main.dust[num631].velocity *= 2f;
			}
			for (int num632 = 0; num632 < 3; num632++)
			{
				float scaleFactor10 = 0.33f;
				if (num632 == 1)
				{
					scaleFactor10 = 0.66f;
				}
				if (num632 == 2)
				{
					scaleFactor10 = 1f;
				}
				int num633 = Gore.NewGore(null, new Vector2(projectile.position.X + projectile.width / 2 - 24f, projectile.position.Y + projectile.height / 2 - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
				Main.gore[num633].velocity *= scaleFactor10;
				Gore expr_13E6D_cp_0 = Main.gore[num633];
				expr_13E6D_cp_0.velocity.X = expr_13E6D_cp_0.velocity.X + 1f;
				Gore expr_13E8D_cp_0 = Main.gore[num633];
				expr_13E8D_cp_0.velocity.Y = expr_13E8D_cp_0.velocity.Y + 1f;
				num633 = Gore.NewGore(null, new Vector2(projectile.position.X + projectile.width / 2 - 24f, projectile.position.Y + projectile.height / 2 - 24f), default(Vector2), Main.rand.Next(61, 64), 2f);
				Main.gore[num633].velocity *= scaleFactor10;
				Gore expr_13F30_cp_0 = Main.gore[num633];
				expr_13F30_cp_0.velocity.X = expr_13F30_cp_0.velocity.X - 1f;
				Gore expr_13F50_cp_0 = Main.gore[num633];
				expr_13F50_cp_0.velocity.Y = expr_13F50_cp_0.velocity.Y + 1f;
				num633 = Gore.NewGore(null, new Vector2(projectile.position.X + projectile.width / 2 - 24f, projectile.position.Y + projectile.height / 2 - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
				Main.gore[num633].velocity *= scaleFactor10;
				Gore expr_13FF3_cp_0 = Main.gore[num633];
				expr_13FF3_cp_0.velocity.X = expr_13FF3_cp_0.velocity.X + 1f;
				Gore expr_14013_cp_0 = Main.gore[num633];
				expr_14013_cp_0.velocity.Y = expr_14013_cp_0.velocity.Y - 1f;
				num633 = Gore.NewGore(null, new Vector2(projectile.position.X + projectile.width / 2 - 24f, projectile.position.Y + projectile.height / 2 - 24f), default(Vector2), Main.rand.Next(61, 64), 1f);
				Main.gore[num633].velocity *= scaleFactor10;
				Gore expr_140B6_cp_0 = Main.gore[num633];
				expr_140B6_cp_0.velocity.X = expr_140B6_cp_0.velocity.X - 1f;
				Gore expr_140D6_cp_0 = Main.gore[num633];
				expr_140D6_cp_0.velocity.Y = expr_140D6_cp_0.velocity.Y - 1f;
			}
			projectile.position.X = projectile.position.X + projectile.width / 2;
			projectile.position.Y = projectile.position.Y + projectile.height / 2;
			projectile.width = 10;
			projectile.height = 10;
			projectile.position.X = projectile.position.X - projectile.width / 2;
			projectile.position.Y = projectile.position.Y - projectile.height / 2;

			if (!modPlayer.pyro && !modPlayer.nitro)
			{
				if (projectile.owner == Main.myPlayer)
				{
					int num220 = Main.rand.Next(3, 8);
					for (int num221 = 0; num221 < num220; num221++)
					{
						Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
						value17.Normalize();
						value17 *= Main.rand.Next(10, 201) * 0.01f;
						Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, value17.X, value17.Y, ModContent.ProjectileType<BoomCloudPro>(), projectile.damage, 1f, projectile.owner, 0f, Main.rand.Next(-45, 1));
					}
				}
			}
			if (projectile.owner == Main.myPlayer)
			{
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
				}
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.25f, projectile.owner);
					Main.projectile[a].scale = 1.25f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 32, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 32, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 32, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 32, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
				}
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.25f, projectile.owner);
					Main.projectile[a].scale = 1.25f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 30, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 30, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[f].scale = 0.7f;
					int g = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[g].scale = 0.7f;
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 50, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[h].scale = 0.7f;
					int i = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 50, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.7f, projectile.owner);
					Main.projectile[i].scale = 0.7f;
					int j = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[j].scale = 0.8f;
					int k = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[k].scale = 0.8f;
					int l = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[l].scale = 0.8f;
					int m = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 0.5f, projectile.owner);
					Main.projectile[m].scale = 0.8f;
				}
				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 40, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y + 40, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y - 40, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y - 40, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && !modPlayer.nitro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y + 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y - 70, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()) && !modPlayer.pyro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()) && !modPlayer.pyro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()) && !modPlayer.pyro)
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X + 100, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X - 100, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item42, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 20, projectile.position.Y, +5, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 20, projectile.position.Y, -5, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item42, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 10, projectile.position.Y - 10, +6, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 10, projectile.position.Y - 10, -6, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y + 10, +4, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y + 10, -4, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.PyroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item42, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[a].scale = 1.5f;
					int b = Projectile.NewProjectile(null, projectile.position.X + 10, projectile.position.Y - 15, +6, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X - 10, projectile.position.Y - 15, -6, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y, +5, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y, -5, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X + 70, projectile.position.Y + 15, +4, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X - 70, projectile.position.Y + 15, -4, 0, ModContent.ProjectileType<BoomSkull>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int z = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[z].scale = 1.25f;
					int a = Projectile.NewProjectile(null, projectile.position.X + 25, projectile.position.Y, 4, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 25, projectile.position.Y, -4, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 25, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 25, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 20, projectile.position.Y + 20, 4, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.8f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 20, projectile.position.Y + 20, -4, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.8f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 20, projectile.position.Y - 20, 4, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.8f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 20, projectile.position.Y - 20, -4, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.8f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int z = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[z].scale = 1.25f;
					int a = Projectile.NewProjectile(null, projectile.position.X + 65, projectile.position.Y, 3, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 65, projectile.position.Y, -3, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 35, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 35, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 1.2f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 1.2f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 1.2f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 1.2f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.RoundBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int z = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1.5f, projectile.owner);
					Main.projectile[z].scale = 1.25f;
					int a = Projectile.NewProjectile(null, projectile.position.X + 65, projectile.position.Y, 3, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X - 65, projectile.position.Y, -3, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 35, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 35, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.8f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.8f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.8f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 50, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.8f;
					int i = Projectile.NewProjectile(null, projectile.position.X + 80, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[i].scale = 0.6f;
					int k = Projectile.NewProjectile(null, projectile.position.X - 80, projectile.position.Y + 20, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[k].scale = 0.6f;
					int l = Projectile.NewProjectile(null, projectile.position.X + 80, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[l].scale = 0.6f;
					int m = Projectile.NewProjectile(null, projectile.position.X - 80, projectile.position.Y - 20, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[m].scale = 0.6f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[d].scale = 1.5f;
					int e = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 3, 3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -3, 3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 3, -3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -3, -3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[d].scale = 1.5f;
					int e = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 2, 3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.75f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -2, 3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.75f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 2, -3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.75f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -2, -3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.75f;
					int i = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 3, 2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[i].scale = 0.75f;
					int j = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -3, 2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[j].scale = 0.75f;
					int k = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 3, -2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[k].scale = 0.75f;
					int l = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -3, -2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[l].scale = 0.75f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.SquareBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 0, ModContent.ProjectileType<BoomBlast>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[d].scale = 1.5f;
					int e = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 2, 4, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[e].scale = 0.65f;
					int f = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -2, 4, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[f].scale = 0.65f;
					int g = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 2, -4, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[g].scale = 0.65f;
					int h = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -2, -4, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[h].scale = 0.65f;
					int i = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 4, 2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[i].scale = 0.65f;
					int j = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -4, 2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[j].scale = 0.65f;
					int k = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 4, -2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[k].scale = 0.65f;
					int l = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -4, -2, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[l].scale = 0.65f;
					int m = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y + 30, 3, 3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[m].scale = 0.7f;
					int n = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y + 30, -3, 3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[n].scale = 0.7f;
					int o = Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y - 30, 3, -3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[o].scale = 0.7f;
					int p = Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y - 30, -3, -3, ModContent.ProjectileType<BoomSkull>(), projectile.damage * 2, 1f, projectile.owner);
					Main.projectile[p].scale = 0.7f;
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					Projectile.NewProjectile(null, projectile.position.X - 30, projectile.position.Y, -2, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 30, projectile.position.Y, +2, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y, -2, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y, +2, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, -3, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, +3, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ChemikazeBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item100, projectile.position);
					Projectile.NewProjectile(null, projectile.position.X - 40, projectile.position.Y, -2, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 40, projectile.position.Y, +2, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, -3, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, +3, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X - 80, projectile.position.Y, -4, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
					Projectile.NewProjectile(null, projectile.position.X + 80, projectile.position.Y, +4, 0, ModContent.ProjectileType<BoomBurst>(), projectile.damage, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.NitroBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 4, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, -4, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, -4, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 4, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, -4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 4, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.ReinforcedBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 6, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, -6, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 6, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, -6, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, -6, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 6, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, -6, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 6, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
				}

				if (player.HasBuffSafe(ModContent.BuffType<Buffs.CrossBlastBuff>()) && player.HasBuffSafe(ModContent.BuffType<Buffs.LinearBurstBuff>()))
				{
					Terraria.Audio.SoundEngine.PlaySound(Terraria.ID.SoundID.Item62, projectile.position);
					int a = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 8, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int b = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, -8, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int c = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, 8, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int d = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, 0, -8, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int e = Projectile.NewProjectile(null, projectile.position.X + 60, projectile.position.Y, -8, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int f = Projectile.NewProjectile(null, projectile.position.X - 60, projectile.position.Y, 8, 0, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int g = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y + 60, 0, -8, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
					int h = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y - 60, 0, 8, ModContent.ProjectileType<BoomSkullburst>(), projectile.damage * 1, 1f, projectile.owner);
				}
			}
		}

	}
}