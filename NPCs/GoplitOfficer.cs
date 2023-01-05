using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Tremor.NPCs
{
	public class GoplitOfficer:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hoplite Officer");
			Main.npcFrameCount[npc.type] = 16;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 300;
			npc.damage = 30;
			npc.defense = 10;
			npc.knockBackResist = 0.1f;
			npc.width = 46;
			npc.height = 42;
			animationType = 86;
			npc.aiStyle = 26;
			npc.npcSlots = 0.3f;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath5;
			npc.value = Item.buyPrice(0, 0, 2, 0);
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 5, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SHGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SHGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SHGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SHGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SHGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/SHGore2"), 1f);
				NPC.NewNPC(null, (int)npc.position.X - 22, (int)npc.position.Y + 55, 481);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.SpawnTileType == TileID.Marble && spawnInfo.SpawnTileY > Main.rockLayer ? 0.001f : 0f;
	}
}