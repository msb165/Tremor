using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class OrcSkeleton:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orc Skeleton");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			AIType = 77;
			npc.lifeMax = 150;
			npc.damage = 30;
			npc.defense = 10;
			npc.knockBackResist = 0.3f;
			npc.width = 36;
			npc.height = 44;
			AnimationType = 482;
			npc.aiStyle = 3;
			npc.npcSlots = 0.6f;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 6, 9);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<OrcSkeletonBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/OrcSkeletonGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/OrcSkeletonGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/OrcSkeletonGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/OrcSkeletonGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/OrcSkeletonGore3"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && NPC.downedBoss1 && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}