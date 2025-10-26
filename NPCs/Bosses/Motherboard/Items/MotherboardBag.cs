using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.NPCs.Bosses.Motherboard.Items
{
	public class MotherboardBag : TremorModItem
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

		////public override int BossBagNPC => ModContent.NPCType<Bosses.Motherboard.Motherboard>();

		public override void SetStaticDefaults()
		{
			ItemID.Sets.BossBag[Type] = true;
			// DisplayName.SetDefault("Motherboard Treasure Bag");
			// Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void ModifyItemLoot(ItemLoot itemLoot)
		{
			itemLoot.Add(ItemDropRule.Common(ItemID.MechanicalWagonPiece));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulofMind>(), 1, 20, 41));
			itemLoot.Add(ItemDropRule.Common(ItemID.GreaterHealingPotion, 1, 15, 36));
			itemLoot.Add(ItemDropRule.Common(ItemID.HallowedBar, 1, 15, 36));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<MotherboardMask>(), 7));
		}
	}
}
