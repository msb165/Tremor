using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class GreatFungusBug:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Great Fungus Bug");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 50;
			npc.damage = 25;
			npc.defense = 10;
			npc.knockBackResist = 0.2f;
			npc.width = 33;
			npc.height = 33;
			AnimationType = 34;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 14;
			AIType = 34;
			npc.npcSlots = 5f;
			npc.HitSound = SoundID.NPCHit35;
			npc.DeathSound = SoundID.NPCDeath57;
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungalBugGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungalBugGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungalBugGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("FungalBugGore3"), 1f);
				for (int k = 0; k < 60; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 67, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 67, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
			}
			else
			{
				for (int k = 0; k < npc.damage / npc.lifeMax * 50; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 67, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
			}
		}
	}
}