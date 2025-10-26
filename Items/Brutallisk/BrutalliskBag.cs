using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Brass;
using Tremor.Items.Crystal;
using Tremor.NPCs.Bosses.CogLord.Items;

namespace Tremor.Items.Brutallisk
{
	public class BrutalliskBag:TremorModItem
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

		//public override int BossBagNPC => ModContent.NPCType<NPCs.Brutallisk>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrutalliskMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Awakening>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SnakeDevourer>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<LightningStaff>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<QuetzalcoatlStave>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TreasureGlaive>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<FallenSnake>(), 25));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<StrangeEgg>(), 100));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrutalliskCrystal>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Aquamarine>(), 1, 10, 18));
		}
	}
}
