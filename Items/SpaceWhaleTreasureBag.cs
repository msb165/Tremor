using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class SpaceWhaleTreasureBag:TremorModItem
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
		public override int BossBagNPC => ModContent.NPCType<SpaceWhale>();
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
				player.QuickSpawnItem(ModContent.ItemType<SpaceWhaleMask>());
			}

			if (Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ModContent.ItemType<StarLantern>());
			}

			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<SDL>());
			}

			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<BlackHoleCannon>());
			}

			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<HornedWarHammer>());
			}

			if (Main.rand.NextBool(8))
			{
				player.QuickSpawnItem(ModContent.ItemType<WhaleFlippers>());
			}
			player.QuickSpawnItem(ModContent.ItemType<LasCannon>());

			player.QuickSpawnItem(ModContent.ItemType<CosmicFuel>());
		}
	}
}
