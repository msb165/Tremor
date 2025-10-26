using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Desert;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class TikiTotemBag:TremorModItem
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
		////public override int BossBagNPC => ModContent.NPCType<TikiTotem>();
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Tiki Totem Treasure Bag");
			// Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot)
		{
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ToxicBlade>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<JungleAlloy>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<JungleAlloy>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PickaxeofBloom>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ToxicHilt>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AngryTotemMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HappyTotemMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<IndifferentTotemMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ItemID.HealingPotion, 1, 5, 16));
			itemLoot.Add(ItemDropRule.Common(ItemID.ManaPotion, 1, 5, 16));
		}
	}
}
