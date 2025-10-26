using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class LihzahrdWarrior:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Lihzahrd Warrior");
			Main.npcFrameCount[npc.type] = 16;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1600;
			npc.damage = 160;
			npc.defense = 82;
			npc.knockBackResist = 0.05f;
			npc.width = 32;
			npc.height = 50;
			AnimationType = 198;
			npc.aiStyle = 3;
			AIType = 529;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = Item.buyPrice(0, 0, 8, 0);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<LihzahrdWarriorBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(6))
				this.NewItem(ItemID.LunarTabletFragment);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LWGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LWGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LWGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LWGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("LWGore3"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Main.hardMode && spawnInfo.SpawnTileType == TileID.LihzahrdBrick && NPC.downedMoonlord && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}