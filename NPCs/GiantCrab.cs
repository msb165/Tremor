using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class GiantCrab:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Giant Crab");
			Main.npcFrameCount[npc.type] = 8;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 300;
			npc.damage = 70;
			npc.defense = 25;
			npc.knockBackResist = 0.3f;
			npc.width = 35;
			npc.height = 28;
			AnimationType = 67;
			npc.aiStyle = 26;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 9, 0);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<GiantCrabBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CrabGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CrabGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CrabGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CrabGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CrabGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("CrabGore3"), 1f);
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(25) == 0)
				npc.NewItem(ModContent.ItemType<CrabClaw>());
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && (spawnInfo.SpawnTileType == 53 || spawnInfo.SpawnTileType == 112 || spawnInfo.SpawnTileType == 116 || spawnInfo.SpawnTileType == 234) && spawnInfo.Water && spawnInfo.SpawnTileY < Main.rockLayer && (spawnInfo.SpawnTileX < 250 || spawnInfo.SpawnTileX > Main.maxTilesX - 250) && !spawnInfo.PlayerSafe && Main.hardMode ? 0.01f : 0f;
	}
}