using System;
using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Ice.Dungeon;
using Tremor.Ice.Items;
using Tremor.Ice.Tree;

namespace Tremor.Ice.Mobs
{
	public class Dot:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Coldtrap");
		}

		public override void SetDefaults()
		{
			npc.lifeMax = Main.hardMode ? 300 : 30;
			npc.damage = Main.hardMode ? 65 : 25;
			//Main.npcFrameCount[npc.type] = 4;
			npc.defense = 0;
			npc.knockBackResist = 0.3f;
			npc.width = 78;
			npc.height = 54;
			//AnimationType = 3;
			npc.aiStyle = 0;
			npc.npcSlots = 1f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 10, 5);
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = npc.lifeMax * 1;
			npc.damage = npc.damage * 1;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			int[] TileArray2 = { ModContent.TileType<IceOre>(), ModContent.TileType<IceBlock>(), ModContent.TileType<VeryVeryIce>(), ModContent.TileType<DungeonBlock>() };
			return TileArray2.Contains(Main.tile[spawnInfo.SpawnTileX, spawnInfo.SpawnTileY].TileType)
				&& !NPC.AnyNPCs(NPCID.LunarTowerVortex)
			    && !NPC.AnyNPCs(NPCID.LunarTowerStardust)
			    && !NPC.AnyNPCs(NPCID.LunarTowerNebula)
			    && !NPC.AnyNPCs(NPCID.LunarTowerSolar) 
				? 15f : 0f;
		}

		public override void AI()
		{
			if (npc.localAI[0] == 0f)
			{
				int damage = Main.hardMode ? 40 : 15;

				for (int k = 1; k < 5; k++)
				{
					int proj = Projectile.NewProjectile(null, npc.Center.X, npc.Center.Y, 0f, 0f, ModContent.ProjectileType<ColdtrapChain>(), damage, 0, Main.myPlayer);

					if (proj == 100)
					{
						npc.active = false;
						return;
					}
					ColdtrapChain arm = Main.projectile[proj].ModProjectile as ColdtrapChain;
					arm.arm = npc.whoAmI;
					arm.width = 16f;
					arm.length = ColdtrapChain.minLength;
					arm.minAngle = (k - 0.05f) * (float)Math.PI / 3f;
					arm.maxAngle = (k + 0.25f) * (float)Math.PI / 3f;
					Main.projectile[proj].rotation = (arm.minAngle + arm.maxAngle) / 3f;
					Main.projectile[proj].netUpdate = true;
				}
				npc.localAI[0] = 1f;
			}
			base.AI();
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(25) == 0)
				Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, 12, 12, ModContent.ItemType<IceKey>(), 1);

			// 20% chance to drop a few ice blocks
			if (Main.rand.NextBool(5))
			{
				this.NewItem(ModContent.ItemType<IceBlockB>(), 2 + Main.rand.Next(4) + (Main.hardMode ? 1 : 0));
			}
			// 10% chance to drop a few ice ores
			if (Main.rand.NextBool(10))
			{
				this.NewItem(ModContent.ItemType<Icicle>(), 2 + Main.rand.Next(3) + (Main.hardMode ? 1 : 0));
			}

			// Explode into a few glaciers
			int num = 2 + Main.rand.Next(2);
			for (int i = 0; i < num; i++)
			{
				NPC.NewNPC(null, (int)npc.position.X, (int)npc.position.Y, ModContent.NPCType<Glacier>());
			}
		}

		public override void ModifyHitPlayer(Player target, ref Player.HurtModifiers modifiers)
		{
			if (Main.hardMode || Main.expertMode)
			{
				target.AddBuff(BuffID.Frostburn, Main.rand.Next(1, 3) * 60);
			}
		}
	}
}