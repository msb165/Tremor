using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs.Bosses.AndasBoss;

namespace Tremor.Items
{
	public class AndasBag : TremorModItem
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
		//public override int BossBagNPC => ModContent.NPCType<TrueAndas>();

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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<GehennaStaff>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<VulcanBlade>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Pandemonium>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HellStorm>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Inferno>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AndasMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AndasCore>()));
			itemLoot.Add(ItemDropRule.Common(ItemID.SuperHealingPotion, 1, 10, 25));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<InfernoSoul>(), 1, 8, 15));
		}
	}
}
