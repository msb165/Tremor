using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.NPCs
{
	public class OceanMimic:TremorModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ocean Mimic");
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
			animationType = NPCID.BigMimicHallow;
		}

		public override void NPCLoot()
		{
			Helper.DropItems(npc.position, npc.Size, new Drop(ModContent.ItemType<TheTide>(), 1, 1), new Drop(ModContent.ItemType<TrueTrident>(), 1, 1), new Drop(ModContent.ItemType<SharkRage>(), 1, 1), new Drop(ModContent.ItemType<OceanAmulet>(), 1, 1), new Drop(ModContent.ItemType<SquidTentacle>(), 1, 1));
			this.NewItem(ItemID.GreaterHealingPotion, Main.rand.Next(10));
			this.NewItem(ItemID.GreaterManaPotion, Main.rand.Next(10));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
			=> Helper.NormalSpawn(spawnInfo) && (spawnInfo.SpawnTileType == 53 || spawnInfo.SpawnTileType == 112 || spawnInfo.SpawnTileType == 116 || spawnInfo.SpawnTileType == 234) && Helper.NoZoneAllowWater(spawnInfo) && spawnInfo.Water && Main.hardMode && spawnInfo.SpawnTileY < Main.rockLayer && (spawnInfo.SpawnTileX < 250 || spawnInfo.SpawnTileX > Main.maxTilesX - 250) && !spawnInfo.PlayerSafe ? 0.01f : 0f;
	}
}