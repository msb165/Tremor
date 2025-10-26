using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class TrinityBag3 : TremorModItem
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HopeMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrustMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TruthMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Banhammer>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BestNightmare>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HonestBlade>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Volcannon>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrebleClef>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Revolwar>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<OmnikronBar>(), 1, 20, 36));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TrueEssense>(), 1, 10, 25));
		}
	}
}
