using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Tiles;

namespace Tremor.NPCs
{

	public class Astrofly:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Astrofly");
			Main.npcFrameCount[npc.type] = 7;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 5000;
			npc.damage = 160;
			npc.defense = 115;
			npc.knockBackResist = 0.2f;
			npc.width = 56;
			npc.height = 12;
			AnimationType = 156;
			npc.aiStyle = 22;
			npc.npcSlots = 15f;
			npc.noTileCollide = true;
			npc.noGravity = true;
			npc.HitSound = SoundID.NPCHit3;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath5;
			npc.value = Item.buyPrice(0, 2, 4, 9);
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<AstroflyBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(2))
				npc.NewItem((short)ModContent.ItemType<CometiteOre>(), Main.rand.Next(2, 5));
			if (Main.rand.NextBool(6))
				npc.NewItem((short)ModContent.ItemType<HardCometiteOre>(), Main.rand.Next(1, 3));
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 59, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 27, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 59, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 27, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 59, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 27, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 59, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);
				}
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/AstroflyGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/AstroflyGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/AstroflyGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("Gores/AstroflyGore3"), 1f);
			}
			else
			{
				for (int k = 0; k < damage / npc.lifeMax * 50.0; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 59, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 59, hitDirection, -1f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 59, hitDirection, -1f, 0, default(Color), 0.7f);
				}
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			int tile = Main.tile[spawnInfo.SpawnTileX, spawnInfo.SpawnTileY].TileType;
			return spawnInfo.SpawnTileY < Main.rockLayer && NPC.downedMoonlord && tile == ModContent.TileType<CometiteOreTile>() || tile == ModContent.TileType<HardCometiteOreTile>() ? 0.005f : 0f;
		}
	}
}