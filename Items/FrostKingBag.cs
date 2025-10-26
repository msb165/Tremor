using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Fungus;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class FrostKingBag:TremorModItem
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
		//public override int BossBagNPC => ModContent.NPCType<FrostKing>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrostKingMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<EdgeofFrostKing>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<FrostoneOre>(), 1, 24, 42));
		}
	}
}
