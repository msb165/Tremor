using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class StormJellyfishBag : TremorModItem
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
		////public override int BossBagNPC => ModContent.NPCType<StormJellyfish>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<StormJellyfishMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<StormBlade>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Poseidon>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<JellyfishStaff>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BoltTome>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<StickyFlail>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<EnchantedHourglass>()));
		}
	}
}
