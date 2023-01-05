using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class StormJellyfishBag:TremorModItem
	{
		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 9;
			item.expert = true;
		}
		public override int BossBagNPC => ModContent.NPCType<StormJellyfish>();
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<StormJellyfishMask>());
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<StormBlade>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<Poseidon>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<JellyfishStaff>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<BoltTome>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<StickyFlail>());
			}
			player.QuickSpawnItem(ModContent.ItemType<EnchantedHourglass>());
		}
	}
}
