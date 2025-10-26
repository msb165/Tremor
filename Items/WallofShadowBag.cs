using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Alchemist.Flasks;
using Tremor.Items.Dark;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class WallofShadowBag : TremorModItem
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
			ItemID.Sets.BossBag[Type] = true;
			// DisplayName.SetDefault("Treasure Bag");
			// Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot)
		{
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HeavyBeamCannon>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Bolter>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<StrikerBlade>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<WallofShadowMask>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DarknessCloth>(), 1, 8, 15));
			itemLoot.Add(ItemDropRule.Common(ItemID.GreaterHealingPotion, 1, 5, 15));
		}
	}
}
