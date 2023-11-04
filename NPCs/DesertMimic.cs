using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Antlion;

namespace Tremor.NPCs
{
	public class DesertMimic:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Mimic");
			Main.npcFrameCount[npc.type] = 14;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 3500;
			npc.damage = 90;
			npc.defense = 34;
			npc.knockBackResist = 0f;
			npc.width = 48;
			npc.height = 40;
			npc.aiStyle = 87;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = Item.buyPrice(0, 3, 0, 0);
			AnimationType = NPCID.BigMimicHallow;
		}

		public override void NPCLoot()
		{
			// Don't know what to do with this loot table.
			Helper.DropItems(npc.position, npc.Size, new Drop(ModContent.ItemType<AntlionFury>(), 1, 1), new Drop(ModContent.ItemType<Hurricane>(), 1, 2), new Drop(ModContent.ItemType<SandShuriken>(), 1, 2), new Drop(ModContent.ItemType<CrawlerHook>(), 1, 1));
			npc.NewItem(ItemID.GreaterHealingPotion, Main.rand.Next(10));
			npc.NewItem(ItemID.GreaterManaPotion, Main.rand.Next(10));
			npc.NewItem(ItemID.GoldenKey);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NoZoneAllowWater(spawnInfo) && Main.hardMode && spawnInfo.Player.ZoneDesert && spawnInfo.SpawnTileY > Main.rockLayer ? 0.01f : 0f;
	}
}