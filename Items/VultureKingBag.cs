using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Tremor.Items.Desert;
using Tremor.Items.Sandstone;
using Tremor.NPCs;
using Tremor.Tiles;

namespace Tremor.Items
{
	public class VultureKingBag : TremorModItem
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<VultureKingMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CactusBow>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SandKnife>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<VultureFeather>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Items.Sandstone.SandstoneBar>(), 2, 10, 18));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DesertClaymore>()));
		}
	}
}
