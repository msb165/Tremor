using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class SpaceWhaleTreasureBag:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.maxStack = 999;
			Item.consumable = true;
			Item.width = 24;
			Item.height = 24;
			Item.rare = 9;
			Item.expert = true;
		}
		////public override int BossBagNPC => ModContent.NPCType<SpaceWhale>();
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Treasure Bag");
			// Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot)
		{
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SpaceWhaleMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<StarLantern>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SDL>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BlackHoleCannon>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HornedWarHammer>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<WhaleFlippers>(), 8));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<LasCannon>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CosmicFuel>()));
		}
	}
}
