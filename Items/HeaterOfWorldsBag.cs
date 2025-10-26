using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class HeaterOfWorldsBag:TremorModItem
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
		//public override int BossBagNPC => ModContent.NPCType<HeaterOfWorldsHead>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HeaterOfWorldsMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<MoltenParts>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<InfernalShield>()));
		}
	}
}
