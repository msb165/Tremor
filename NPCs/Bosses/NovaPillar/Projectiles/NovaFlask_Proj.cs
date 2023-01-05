using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Buffs;
using Tremor.Projectiles;

namespace Tremor.NPCs.Bosses.NovaPillar.Projectiles
{
	public class NovaFlask_Proj:TremorModProjectile
	{
		public override ModProjectile NewInstance(Projectile projectileClone) => base.NewInstance(projectileClone);

		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 18;
			projectile.height = 28;
			projectile.friendly = true;
			projectile.aiStyle = 2;
			projectile.timeLeft = 1200;
			try
			{
				projectile.penetrate = Main.LocalPlayer.HasBuffSafe(ModContent.BuffType<BouncingCasingBuff>()) ? 3 : 1;
			}
			catch
			{
				projectile.penetrate = 1;
			}
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (Main.LocalPlayer.HasBuffSafe(ModContent.BuffType<BouncingCasingBuff>()))
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
					SoundEngine.PlaySound(SoundID.Item10, projectile.position);
				}
			}
			else
			{
				projectile.Kill();
			}

			return false;
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

		public override void Kill(int timeLeft)
		{
			Player player = Main.player[projectile.owner];
			MPlayer modPlayer = player.GetModPlayer<MPlayer>();
			SoundEngine.PlaySound(SoundID.Item107, projectile.position);
			Gore.NewGore(null, projectile.position, -projectile.oldVelocity * 0.2f, 704, 1f);
			Gore.NewGore(null, projectile.position, -projectile.oldVelocity * 0.2f, 705, 1f);
			Gore.NewGore(null, projectile.position, -projectile.oldVelocity * 0.2f, 705, 1f);
			if (projectile.owner == Main.myPlayer)
			{
				int num220 = Main.rand.Next(2, 3);
				for (int num221 = 0; num221 < num220; num221++)
				{
					Vector2 value17 = new Vector2(Main.rand.Next(-100, 101), Main.rand.Next(-100, 101));
					value17.Normalize();
					value17 *= Main.rand.Next(10, 201) * 0.01f;
					int k = Projectile.NewProjectile(null, projectile.position.X, projectile.position.Y, value17.X, value17.Y, ModContent.ProjectileType<NovaFlask_ProjBall>(), projectile.damage, 1f, projectile.owner, 0f, Main.rand.Next(-45, 1));
					Main.projectile[k].friendly = true;
				}
			}

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
		}

		public override bool PreDraw(ref Color lightColor)
		{
			Vector2 drawOrigin = new Vector2(TextureAssets.Projectile[projectile.type].Width() * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				Main.spriteBatch.Draw(TextureAssets.Projectile[projectile.type].Value, drawPos, null, color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return true;
		}
	}
}