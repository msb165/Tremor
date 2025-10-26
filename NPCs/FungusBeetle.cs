using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Fungus;

namespace Tremor.NPCs
{
	[AutoloadBossHead]
	public class FungusBeetle:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Fungus Beetle");
			Main.npcFrameCount[npc.type] = 4;
		}

		Vector2 Hands = new Vector2(-1, -1);
		public override void SetDefaults()
		{
			npc.lifeMax = 4200;
			npc.width = 214;
			npc.height = 114;
			AnimationType = 82;
			npc.damage = 30;
			npc.defense = 25;
			npc.knockBackResist = 0f;
			npc.aiStyle = 14;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit35;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath57;
			npc.color = Color.White;
			npc.boss = true;
			npc.noTileCollide = true;
			bossBag = ModContent.ItemType<FungusBeetleBag>();
		}

		public override void NPCLoot()
		{
			if (Main.expertMode)
			{
				DropBossBags();
			}
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + npc.width / 2) / 16;
				int centerY = (int)(npc.position.Y + npc.height / 2) / 16;
				int halfLength = npc.width / 2 / 16 + 1;
				if (!Main.expertMode && Main.rand.NextBool(7))
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FungusBeetleMask>());
				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FungusBeetleTrophy>());
				}
				if (!Main.expertMode)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FungusElement>(), Main.rand.Next(10, 23));
				}
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, 28, Main.rand.Next(9, 22));
				TremorWorld.Boss.FungusBeetle.Downed();
			}
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungusBeetleGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungusBeetleGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungusBeetleGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungusBeetleGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungusBeetleGore4"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungusBeetleGore4"), 1f);
				for (int k = 0; k < 10; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 67, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
			}

			for (int k = 0; k < npc.damage / npc.lifeMax * 50.0; k++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 67, hit.HitDirection, -1f, 0, default(Color), 0.7f);
			}
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = (int)(npc.lifeMax * 0.625f * balance);
			npc.damage = (int)(npc.damage * 0.6f);
		}

		const string Boss_Left_Hand_Type = "Violeum_LeftArm";
		const string Boss_Right_Hand_Type = "Violeum_RightArm";
		const string Boss_Up_Hand_Type = "Violeum_LeftArm";
		const string Boss_Down_Hand_Type = "Violeum_RightArm";

		void MakeHands()
		{
			Hands.X = NPC.NewNPC(null, (int)npc.Center.X - 50, (int)npc.Center.Y, Mod.NPCType(Boss_Left_Hand_Type), 0, 1, npc.whoAmI);
			Hands.Y = NPC.NewNPC(null, (int)npc.Center.X + 50, (int)npc.Center.Y, Mod.NPCType(Boss_Right_Hand_Type), 0, -1, npc.whoAmI);
			Hands.Y = NPC.NewNPC(null, (int)npc.Center.X, (int)npc.Center.Y - 1000, Mod.NPCType(Boss_Down_Hand_Type), 0, -1, npc.whoAmI);
			Hands.Y = NPC.NewNPC(null, (int)npc.Center.X, (int)npc.Center.Y + 1000, Mod.NPCType(Boss_Up_Hand_Type), 0, -1, npc.whoAmI);
		}

		void CheckHands()
		{
			if (Hands.X != -1)
				if (!((Main.npc[(int)Hands.X].type == Mod.NPCType(Boss_Left_Hand_Type) && Main.npc[(int)Hands.X].ai[1] == npc.whoAmI) && Main.npc[(int)Hands.X].active))
					Hands.X = -1;
			if (Hands.Y != -1)
				if (!((Main.npc[(int)Hands.Y].type == Mod.NPCType(Boss_Right_Hand_Type) && Main.npc[(int)Hands.Y].ai[1] == npc.whoAmI) && Main.npc[(int)Hands.Y].active))
					Hands.Y = -1;
			if (Hands.X != -1)
				if (!((Main.npc[(int)Hands.X].type == Mod.NPCType(Boss_Up_Hand_Type) && Main.npc[(int)Hands.X].ai[1] == npc.whoAmI) && Main.npc[(int)Hands.X].active))
					Hands.X = -1;
			if (Hands.Y != -1)
				if (!((Main.npc[(int)Hands.Y].type == Mod.NPCType(Boss_Down_Hand_Type) && Main.npc[(int)Hands.Y].ai[1] == npc.whoAmI) && Main.npc[(int)Hands.Y].active))
					Hands.Y = -1;
		}

		public override void ModifyHitByProjectile(Projectile projectile, ref NPC.HitModifiers modifiers)
		{
			CheckHands();
			if (Hands.Y != -1)
				modifiers.FinalDamage /= 10;
		}

		public override void ModifyHitByItem(Player player, Item item, ref NPC.HitModifiers modifiers)
		{
			CheckHands();
			if (Hands.Y != -1)
				modifiers.FinalDamage /= 10;
		}

		public override void ModifyHitPlayer(Player target, ref Player.HurtModifiers modifiers)
		{
			CheckHands();
			if (Hands.Y != -1)
				modifiers.FinalDamage /= 10;
		}

		public override void ModifyHitNPC(NPC target, ref NPC.HitModifiers modifiers)
		{
			CheckHands();
			if (Hands.Y != -1)
				modifiers.FinalDamage /= 10;
		}

		float customAi1;
		bool FirstState;
		bool SecondState;
		public override void AI()
		{
			npc.position -= npc.velocity * 0.05f;

			if (NPC.AnyNPCs(ModContent.NPCType<GreatFungusBug>()))
			{
				npc.dontTakeDamage = true;
			}
			if (!NPC.AnyNPCs(ModContent.NPCType<GreatFungusBug>()))
			{
				npc.dontTakeDamage = false;
			}

			bool allDead = false;
			for (int i = 0; i < Main.player.Length; i++)
			{
				if (Main.player[i].dead) allDead = true;
			}

			if (allDead)
			{
				if (npc.velocity.X > 0f)
				{
					npc.velocity.X = npc.velocity.X + 0.75f;
				}
				else
				{
					npc.velocity.X = npc.velocity.X - 0.75f;
				}
				npc.velocity.Y = npc.velocity.Y - 0.1f;
				npc.rotation = npc.velocity.X * 0.05f;
			}

			if (Main.rand.Next(120) == 0 && !Main.expertMode)
			{
				NPC.NewNPC(null, (int)npc.Center.X - 70, (int)npc.Center.Y, 261);
			}

			if (Main.rand.Next(110) == 0 && Main.expertMode)
			{
				NPC.NewNPC(null, (int)npc.Center.X - 70, (int)npc.Center.Y, 261);
			}

			if (Main.rand.Next(200) == 0)
			{
				NPC.NewNPC(null, (int)npc.Center.X - 70, (int)npc.Center.Y, ModContent.NPCType<LittleMushroomBug>());
			}

			if (Main.rand.Next(500) == 0)
			{
				NPC.NewNPC(null, (int)npc.Center.X - 70, (int)npc.Center.Y, ModContent.NPCType<GreatFungusBug>());
			}

			if (npc.life > npc.lifeMax / 2)
			{
				FirstState = true;
			}

			if (npc.life < npc.lifeMax / 2)
			{
				SecondState = true;
			}

			if (Main.rand.NextBool(2))
			{
				int num706 = Dust.NewDust(npc.position, npc.width, npc.height, 67, 0f, 0f, 200, npc.color, 0.5f);
				Main.dust[num706].velocity *= 0.6f;
			}
			if (FirstState)
			{
				npc.TargetClosest();
				npc.netUpdate = false;
				npc.ai[1]++;

				npc.TargetClosest(true);
				Vector2 PTC = Main.player[npc.target].position + new Vector2(npc.width / 2, npc.height / 2);
				Vector2 NPos = npc.position + new Vector2(npc.width / 2, npc.height / 2);
				npc.netUpdate = true;

				customAi1 += (Main.rand.Next(2, 5) * 0.1f) * npc.scale;
				npc.netUpdate = true;

				npc.ai[1] += (Main.rand.Next(2, 5) * 0.1f) * npc.scale;
				if (npc.ai[1] >= 10f)
				{
					npc.TargetClosest(true);
					if (Main.rand.Next(60) == 0)
					{
						Vector2 vector8 = new Vector2(npc.position.X + (npc.width * 0.5f), npc.position.Y + (npc.height / 2));
						float rotation = (float)Math.Atan2(vector8.Y - (Main.player[npc.target].position.Y + (Main.player[npc.target].height * 0.5f)), vector8.X - (Main.player[npc.target].position.X + (Main.player[npc.target].width * 0.5f)));
						npc.velocity.X = (float)(Math.Cos(rotation) * 14) * -1;
						npc.velocity.Y = (float)(Math.Sin(rotation) * 14) * -1;
						npc.ai[1] = 1f;
						npc.netUpdate = true;
					}
				}

				int num60;
				npc.TargetClosest(true);

				if (Main.player[npc.target].position.Y - 150 > npc.position.Y)
				{
					npc.directionY = 1;
				}
				else
				{
					npc.directionY = -1;
				}

				if (npc.direction == -1 && npc.velocity.X > -2f)
				{
					npc.velocity.X = npc.velocity.X - 0.4f;
					if (npc.velocity.X > 2f)
					{
						npc.velocity.X = npc.velocity.X - 0.4f;
					}
					else
					{
						if (npc.velocity.X > 0f)
						{
							npc.velocity.X = npc.velocity.X + 0.08f;
						}
					}
					if (npc.velocity.X < -2f)
					{
						npc.velocity.X = -2f;
					}
				}
				else
				{
					if (npc.direction == 1 && npc.velocity.X < 4f)
					{
						npc.velocity.X = npc.velocity.X + 0.1f;
						if (npc.velocity.X < -2f)
						{
							npc.velocity.X = npc.velocity.X + 0.1f;
						}
						else
						{
							if (npc.velocity.X < 0f)
							{
								npc.velocity.X = npc.velocity.X - 0.08f;
							}
						}
						if (npc.velocity.X > 2f)
						{
							npc.velocity.X = 2f;
						}
					}
				}
				if (npc.directionY == -1 && npc.velocity.Y > -1.5)
				{
					npc.velocity.Y = npc.velocity.Y - 0.08f;

					if (npc.velocity.Y < -1.5)
					{
						npc.velocity.Y = -1.5f;
					}
				}
				else
				{
					if (npc.directionY == 1 && npc.velocity.Y < 1.5)
					{
						npc.velocity.Y = npc.velocity.Y + 0.08f;
						if (npc.velocity.Y > 1.5)
						{
							npc.velocity.Y = 1.5f;
						}
					}
				}
			}
		}
	}
}