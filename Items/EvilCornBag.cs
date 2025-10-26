using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class EvilCornBag:TremorModItem
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
		//public override int BossBagNPC => ModContent.NPCType<EvilCorn>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<EvilCornMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<EvilCornTrophy>(), 10));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CornHeater>(), 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<GrayKnightHelmet>(), 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<GrayKnightBreastplate>(), 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<KnightGreaves>(), 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CornSword>(), 3));
			if (!Main.LocalPlayer.HasItem(ModContent.ItemType<FarmerShovel>()))
			{
				itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<FarmerShovel>()));
			}
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Corn>(), 1, 25, 48));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CornJavelin>(), 1, 15, 45));
		}
	}
}
