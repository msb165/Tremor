using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class SandThing:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sand Thing");
			Main.npcFrameCount[npc.type] = 13;
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
			npc.damage = 22;
			npc.defense = 21;
			npc.lifeMax = 145;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = Item.buyPrice(0, 0, 3, 7);
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			AIType = 73;
			npc.aiStyle = 3;
			AnimationType = 166;
			Banner = npc.type;
			BannerItem = ModContent.ItemType<SandThingBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(50) == 0)
				this.NewItem(ItemID.IllegalGunParts);
			if (Main.rand.NextBool())
				this.NewItem(ItemID.SandBlock);
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
				{
					Dust.NewDust(npc.position, npc.width, npc.height, 19, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
					Dust.NewDust(npc.position, npc.width, npc.height, 19, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				}

				Dust.NewDust(npc.position, npc.width, npc.height, 19, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 19, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 2.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 19, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 2.7f);
				Dust.NewDust(npc.position, npc.width, npc.height, 19, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 1.7f);

				Gore.NewGore(null, npc.position, npc.velocity, 220, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 221, 1f);
				Gore.NewGore(null, npc.position, npc.velocity, 222, 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Player.ZoneDesert && NPC.downedBoss1 && Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.01f : 0f;
	}
}
