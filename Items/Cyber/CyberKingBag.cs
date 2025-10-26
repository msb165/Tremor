using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Dark;
using Tremor.Items.Souls;
using Tremor.NPCs;

namespace Tremor.Items.Cyber
{
	public class CyberKingBag:TremorModItem
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
		////public override int BossBagNPC => ModContent.NPCType<CyberKing>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CyberKingMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<RedStorm>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CyberCutter>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ShockwaveClaymore>(), 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CyberStaff>()));
		}
	}
}
