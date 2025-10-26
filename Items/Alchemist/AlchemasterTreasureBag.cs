using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Alchemist.Flasks;
using Tremor.Items.Ancient;
using Tremor.NPCs;

namespace Tremor.Items.Alchemist
{
	public class AlchemasterTreasureBag:TremorModItem
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
		//public override int BossBagNPC => ModContent.NPCType<Alchemaster>();

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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AlchemasterMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AlchemasterTrophy>(), 10));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PlagueFlask>(), 2, 30, 78));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SparkingFlask>(), 2, 30, 78));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheGlorch>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BadApple>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<GoldenStar>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<LongFuse>()));
		}
	}
}
