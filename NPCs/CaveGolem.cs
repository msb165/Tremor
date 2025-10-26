using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class CaveGolem:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Cave Golem");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 80;
			npc.damage = 20;
			npc.defense = 17;
			npc.knockBackResist = 0.3f;
			AIType = 77;
			npc.width = 36;
			npc.height = 44;
			AnimationType = 482;
			npc.aiStyle = 3;
			npc.npcSlots = 0.9f;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 4, 9);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<CaveGolemBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CaveGolemGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CaveGolemGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CaveGolemGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CaveGolemGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CaveGolemGore3"), 1f);
			}
		}

		public override void NPCLoot()
		{
			npc.NewItem(ModContent.ItemType<ColossusSword>());
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}