using Terraria.ID;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Wood;

namespace Tremor.NPCs
{
	public class TikiSorcerer:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tiki Sorcerer");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 80;
			npc.damage = 25;
			npc.defense = 3;
			npc.knockBackResist = 0.6f;
			npc.width = 30;
			npc.height = 46;
			AnimationType = 29;
			npc.aiStyle = 8;
			npc.npcSlots = 15f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 0);
		}

		public override void ApplyDifficultyAndPlayerScaling(int numPlayers, float balance, float bossAdjustment)/* tModPorter Note: bossLifeScale -> balance (bossAdjustment is different, see the docs for details) */
		{
			npc.lifeMax = (int)(npc.lifeMax * 1);
			npc.damage = (int)(npc.damage * 1);
		}

		public override void NPCLoot()
		{
			if (Main.netMode != 1)
			{
				int centerX = (int)(npc.position.X + (float)(npc.width / 2)) / 16;
				int centerY = (int)(npc.position.Y + (float)(npc.height / 2)) / 16;
				int halfLength = npc.width / 2 / 16 + 1;

				if (Main.rand.Next(45) == 0)
				{
					Item.NewItem(null, (int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WoodenFrame>());
				};
			}
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * (float)hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TSGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TSGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TSGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TSGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TSGore3"), 1f);
			}
		}
	}
}