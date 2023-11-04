using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class Woodling:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Woodling");
			Main.npcFrameCount[npc.type] = 10;
		}
		
		public override void SetDefaults()
		{
			npc.lifeMax = 90;
			npc.damage = 14;
			npc.defense = 9;
			npc.knockBackResist = 0.3f;
			npc.width = 56;
			npc.height = 48;
			AIType = 429;
			AnimationType = 429;
			npc.aiStyle = 3;
			npc.npcSlots = 0.2f;
			npc.HitSound = SoundID.NPCHit37;
			npc.DeathSound = SoundID.NPCDeath57;
			npc.value = Item.buyPrice(0, 0, 6, 9);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<WoodlingBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool())
				this.NewItem(ItemID.Wood, Main.rand.Next(1, 6));
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 74, 2.5f * hitDirection, -2.5f, 0, default(Color), 1f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/WoodlingGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/WoodlingGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/WoodlingGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/WoodlingGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/WoodlingGore3"), 1f);

			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && NPC.downedBoss1 && Helper.NoZoneAllowWater(spawnInfo) && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.002f : 0f;
	}
}