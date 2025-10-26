using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Brass;
using Tremor.Items.Cyber;

namespace Tremor.NPCs.Bosses.CogLord.Items
{
	public class CogLordBag : TremorModItem
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

		//public override int BossBagNPC => ModContent.NPCType<CogLord>();

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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CogLordMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrassRapier>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrassChainRepeater>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrassStave>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrassChip>(), 10));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HeatCore>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BrassNugget>(), 1, 18, 32));
		}
	}
}
