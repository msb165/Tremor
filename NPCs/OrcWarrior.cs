using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;
using Tremor.Items.Orcish;

namespace Tremor.NPCs
{
	public class OrcWarrior:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Orc Warrior");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 175;
			npc.damage = 30;
			npc.defense = 10;
			npc.knockBackResist = 0.3f;
			npc.width = 48;
			npc.height = 54;
			AnimationType = 482;
			npc.aiStyle = 3;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath40;
			npc.value = Item.buyPrice(0, 0, 6, 7);
			Banner = npc.type;
			BannerItem = ModContent.ItemType<OrcWarriorBanner>();
		}

		public override void HitEffect(NPC.HitInfo hit)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hit.HitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("OrcWarriorGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("OrcWarriorGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("OrcWarriorGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("OrcWarriorGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, Mod.GetGoreSlot("OrcWarriorGore4"), 1f);
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(30) == 0)
				this.NewItem(ModContent.ItemType<OrcishHelmet>());
			if (Main.rand.Next(30) == 0)
				this.NewItem(ModContent.ItemType<OrcishBreastplate>());
			if (Main.rand.Next(30) == 0)
				this.NewItem(ModContent.ItemType<OrcishGreaves>());
			if (Main.rand.Next(30) == 0)
				this.NewItem(ModContent.ItemType<OrcishBroadsword>());
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && NPC.downedBoss1 && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.1f : 0f;
	}
}