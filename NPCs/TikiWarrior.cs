using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Wood;

namespace Tremor.NPCs
{
	public class TikiWarrior:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tiki Warrior");
			Main.npcFrameCount[npc.type] = 3;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 120;
			npc.damage = 26;
			npc.defense = 5;
			npc.knockBackResist = 0.3f;
			npc.width = 56;
			npc.height = 48;
			AnimationType = 3;
			npc.aiStyle = 3;
			AIType = 73;
			npc.npcSlots = 15f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 0, 0);
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(45) == 0)
				this.NewItem(ModContent.ItemType<WoodenFrame>());
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TikiWarriorGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TikiWarriorGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TikIWarriorGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("TikiWarriorGore3"), 1f);
			}
		}
	}
}