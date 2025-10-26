using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.ZombieEvent.Mobs
{

	public class Corpse1:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corpse");
			Main.npcFrameCount[npc.type] = 9;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 80;
			npc.damage = 60;
			npc.defense = 20;
			npc.knockBackResist = 0.3f;
			npc.width = 34;
			npc.height = 34;
			AnimationType = 462;
			AIType = 462;
			npc.aiStyle = 3;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 8, 7);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<LittleCorpseBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CorpseGore1"), 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CorpseGore2"), 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CorpseGore2"), 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CorpseGore3"), 0.8f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CorpseGore3"), 0.8f);
			}
		}

	}
}