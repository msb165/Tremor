using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class Zootaloo:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Zootaloo");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 120;
			npc.damage = 22;
			npc.defense = 8;
			npc.knockBackResist = 0.2f;
			npc.width = 34;
			npc.height = 48;
			AnimationType = 48;
			npc.aiStyle = 14;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit35;
			npc.noGravity = true;
			npc.DeathSound = SoundID.NPCDeath57;
			// Banner = npc.type;
			// Todo: BannerItem = ModContent.ItemType<ZootalooBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.NextBool(3))
				this.NewItem(ModContent.ItemType<LightBulb>(), Main.rand.Next(1, 3));
			if (Main.rand.NextBool(2))
				this.NewItem(ModContent.ItemType<Gloomstone>(), Main.rand.Next(5, 13));
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 44, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZootalooGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZootalooGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("ZootalooGore2"), 1f);
			}
			else
			{
				for (int k = 0; k < npc.damage / npc.lifeMax * 50; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 44, hit.HitDirection, -1f, 0, default(Color), 0.7f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.01f : 0f;
	}
}