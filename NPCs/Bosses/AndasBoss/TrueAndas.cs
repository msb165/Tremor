using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Souls;

namespace Tremor.NPCs.Bosses.AndasBoss
{
	[AutoloadBossHead]
	public class TrueAndas:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Andas");
		}
		public override void SetDefaults()
		{
			npc.aiStyle = -1;
			npc.width = 142;
			npc.height = 164;
			npc.damage = 67;
			npc.defense = 200;
			npc.lifeMax = 145000;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath10;
			npc.value = 60000f;
			npc.knockBackResist = 0f;
			npc.noTileCollide = true;
			npc.noGravity = true;
			npc.boss = true;
			music = MusicID.Boss5;
			bossBag = ModContent.ItemType<AndasBag>();
			npc.buffImmune[24] = true;
			npc.buffImmune[67] = true;
			npc.lavaImmune = true;
		}

		#region Settings AI
		const int ShootType = 467;
		const int ShootDamage = 50;
		const float ShootKnockback = 2f;
		const int ShootCount = 5;
		const int ShootSpeed = 5;
		const int ShootDirection = 7;
		const float Speed = 18f;
		const float Acceleration = 0.15f;
		int Timer;
		#endregion

		//@todo
		public override void AI()
		{
			npc.TargetClosest(true);
			npc.spriteDirection = npc.direction;
			Player player = Main.player[npc.target];
			if (player.dead || !player.active || !Main.dayTime)
			{
				npc.TargetClosest(false);
				npc.active = false;
			}
			Timer++;
			if (Timer >= 0 && Timer <= 1000) //flight
			{
				Vector2 StartPosition = new Vector2(npc.position.X + npc.width * 0.5f, npc.position.Y + npc.height * 0.5f);
				float DirectionX = Main.player[npc.target].position.X + Main.player[npc.target].width / 2 - StartPosition.X;
				float DirectionY = Main.player[npc.target].position.Y + (Main.player[npc.target].height / 2) - 120 - StartPosition.Y;
				float Length = (float)Math.Sqrt(DirectionX * DirectionX + DirectionY * DirectionY);
				float Num = Speed / Length;
				DirectionX = DirectionX * Num;
				DirectionY = DirectionY * Num;
				if (npc.velocity.X < DirectionX)
				{
					npc.velocity.X = npc.velocity.X + Acceleration;
					if (npc.velocity.X < 0 && DirectionX > 0)
						npc.velocity.X = npc.velocity.X + Acceleration;
				}
				else if (npc.velocity.X > DirectionX)
				{
					npc.velocity.X = npc.velocity.X - Acceleration;
					if (npc.velocity.X > 0 && DirectionX < 0)
						npc.velocity.X = npc.velocity.X - Acceleration;
				}
				if (npc.velocity.Y < DirectionY)
				{
					npc.velocity.Y = npc.velocity.Y + Acceleration;
					if (npc.velocity.Y < 0 && DirectionY > 0)
						npc.velocity.Y = npc.velocity.Y + Acceleration;
				}
				else if (npc.velocity.Y > DirectionY)
				{
					npc.velocity.Y = npc.velocity.Y - Acceleration;
					if (npc.velocity.Y > 0 && DirectionY < 0)
						npc.velocity.Y = npc.velocity.Y - Acceleration;
				}
				if (Main.rand.Next(36) == 1)
				{
					Vector2 StartPosition2 = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height / 2));
					float AndasRotation = (float)Math.Atan2(StartPosition2.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), StartPosition2.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
					npc.velocity.X = (float)(Math.Cos(AndasRotation) * 18) * -1;
					npc.velocity.Y = (float)(Math.Sin(AndasRotation) * 18) * -1;
					npc.netUpdate = true;
				}
			}

			if (Timer == 700)
			{
				for (int i = 0; i < 50; i++)
				{
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 57);
					Main.dust[dust].scale = 1.5f;
				}
				DoAndasShoot();
				npc.position.X = (Main.player[npc.target].position.X - 500) + Main.rand.Next(1000);
				npc.position.Y = (Main.player[npc.target].position.Y - 500) + Main.rand.Next(1000);
			}

			if (Timer == 850)
			{
				for (int i = 0; i < 50; i++)
				{
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 57);
					Main.dust[dust].scale = 1.5f;
				}
				DoAndasShoot();
				npc.position.X = (Main.player[npc.target].position.X - 500) + Main.rand.Next(1000);
				npc.position.Y = (Main.player[npc.target].position.Y - 500) + Main.rand.Next(1000);
			}

			if (Timer == 1000)
			{
				for (int i = 0; i < 50; i++)
				{
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 57);
					Main.dust[dust].scale = 1.5f;
				}
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<MoltenSpirit>());
				DoAndasShoot();
				npc.position.X = (Main.player[npc.target].position.X - 500) + Main.rand.Next(1000);
				npc.position.Y = (Main.player[npc.target].position.Y - 500) + Main.rand.Next(1000);
			}

			if (Timer == 1150)
			{
				for (int i = 0; i < 50; i++)
				{
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 57);
					Main.dust[dust].scale = 1.5f;
				}
				DoAndasShoot();
				npc.position.X = (Main.player[npc.target].position.X - 500) + Main.rand.Next(1000);
				npc.position.Y = (Main.player[npc.target].position.Y - 500) + Main.rand.Next(1000);
			}

			if (Timer == 1300)
			{
				for (int i = 0; i < 50; i++)
				{
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 57);
					Main.dust[dust].scale = 1.5f;
				}
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<UndeadWyrmHead>());
				npc.position.X = (Main.player[npc.target].position.X - 500) + Main.rand.Next(1000);
				npc.position.Y = (Main.player[npc.target].position.Y - 500) + Main.rand.Next(1000);
			}

			if (Timer > 1300)
			{
				Timer = 0;
			}
		}

		void DoAndasShoot()
		{
			Projectile.NewProjectile(null, npc.position.X + 40, npc.position.Y + 40, -ShootDirection, 0, ModContent.ProjectileType<InfernoSkull>(), ShootDamage, ShootKnockback, Main.myPlayer, 0f, 0f);
			Projectile.NewProjectile(null, npc.position.X + 40, npc.position.Y + 40, ShootDirection, 0, ModContent.ProjectileType<InfernoSkull>(), ShootDamage, ShootKnockback, Main.myPlayer, 0f, 0f);
			Projectile.NewProjectile(null, npc.position.X + 40, npc.position.Y + 40, 0, ShootDirection, ModContent.ProjectileType<InfernoSkull>(), ShootDamage, ShootKnockback, Main.myPlayer, 0f, 0f);
			Projectile.NewProjectile(null, npc.position.X + 40, npc.position.Y + 40, 0, -ShootDirection, ModContent.ProjectileType<InfernoSkull>(), ShootDamage, ShootKnockback, Main.myPlayer, 0f, 0f);
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
		{
			Texture2D drawTexture = Terraria.GameContent.TextureAssets.Npc[npc.type].Value;
			Vector2 origin = new Vector2((drawTexture.Width / 2) * 0.5F, (drawTexture.Height / Main.npcFrameCount[npc.type]) * 0.5F);

			Vector2 drawPos = new Vector2(
				npc.position.X - Main.screenPosition.X + (npc.width / 2) - (Terraria.GameContent.TextureAssets.Npc[npc.type].Value.Width / 2) * npc.scale / 2f + origin.X * npc.scale,
				npc.position.Y - Main.screenPosition.Y + npc.height - Terraria.GameContent.TextureAssets.Npc[npc.type].Value.Height * npc.scale / Main.npcFrameCount[npc.type] + 4f + origin.Y * npc.scale + npc.gfxOffY);

			SpriteEffects effects = npc.spriteDirection == -1 ? SpriteEffects.None : SpriteEffects.FlipHorizontally;
			spriteBatch.Draw(drawTexture, drawPos, npc.frame, Color.White, npc.rotation, origin, npc.scale, effects, 0);

			return false;
		}

		public override void NPCLoot()
		{
			TremorWorld.Boss.Andas.Downed();

			if (Main.expertMode)
			{
				DropBossBags();
			}
			else
			{
				Helper.DropItems(npc.position, npc.Size, new Drop(ModContent.ItemType<Inferno>(), 1, 1), new Drop(ModContent.ItemType<GehennaStaff>(), 1, 1), new Drop(ModContent.ItemType<Pandemonium>(), 1, 1), new Drop(ModContent.ItemType<VulcanBlade>(), 1, 1), new Drop(ModContent.ItemType<HellStorm>(), 1, 1));
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 3544, Main.rand.Next(10, 25));

				if (Main.rand.NextBool(7))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AndasMask>());
				}
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<InfernoSoul>(), Main.rand.Next(8, 15));
			}

			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AndasTrophy>());
			}

			if (Main.netMode != 1)
			{
				int num1 = (int)(npc.position.X + (npc.width / 2)) / 16;
				int num2 = (int)(npc.position.Y + (npc.height / 2)) / 16;
				int num5 = npc.width / 2 / 16 + 1;
				for (int index2 = num1 - num5; index2 <= num1 + num5; ++index2)
				{
					for (int index3 = num2 - num5; index3 <= num2 + num5; ++index3)
					{
						var tile = Main.tile[index2, index3];
						if ((index2 == num1 - num5 || index2 == num1 + num5 || (index3 == num2 - num5 || index3 == num2 + num5)) && !Main.tile[index2, index3].active())
						{
							tile.TileType = 76;
							tile.active(true);
						}
						tile.LiquidType = LiquidID.Water;//was tile.lava(false)
						tile.LiquidAmount = 0;
						if (Main.netMode == 2)
							NetMessage.SendTileSquare(-1, index2, index3, 1);
						else
							WorldGen.SquareTileFrame(index2, index3, true);
					}
				}

				//if (Main.netMode == 2)
				//NetMessage.SendData(7, -1, -1, "", 0, 0.0f, 0.0f, 0.0f, 0, 0, 0);
			}

		}
	}
}