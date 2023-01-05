using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

using Tremor.Items;

namespace Tremor.NPCs
{
	public class SupremePossessedArmor:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Supreme Possessed Armor");
			Main.npcFrameCount[npc.type] = 20;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 1250;
			npc.damage = 125;
			npc.defense = 28;
			npc.knockBackResist = 0.3f;
			npc.width = 36;
			npc.height = 44;
			animationType = 482;
			npc.aiStyle = 3;
			aiType = 77;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 0, 40, 7);
			banner = npc.type;
			bannerItem = ModContent.ItemType<SupremePossessedArmorBanner>();
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(30) == 0)
				this.NewItem(ModContent.ItemType<ShadowCutter>());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			if (npc.life <= 0)
			{
				for (int k = 0; k < 20; k++)
					Dust.NewDust(npc.position, npc.width, npc.height, 151, 2.5f * hitDirection, -2.5f, 0, default(Color), 0.7f);

				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/PossessedGore1"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/PossessedGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/PossessedGore2"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/PossessedGore3"), 1f);
				Gore.NewGore(null, npc.position, npc.velocity, mod.GetGoreSlot("Gores/PossessedGore3"), 1f);
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && Helper.NoZoneAllowWater(spawnInfo) && NPC.downedMechBossAny && !Main.dayTime && spawnInfo.SpawnTileY < Main.worldSurface ? 0.1f : 0f;
	}
}