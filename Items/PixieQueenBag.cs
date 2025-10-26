using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Chaos;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class PixieQueenBag:TremorModItem
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
		////public override int BossBagNPC => ModContent.NPCType<PixieQueen>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PixieQueenMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<EtherealFeather>(), 6));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PixiePulse>(), 6));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HeartMagnet>(), 6));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DopelgangerCandle>(), 6));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<GlorianaWrath>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ChaosBar>(), 1, 15, 25));
		}
	}
}
