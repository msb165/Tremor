using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs;

namespace Tremor.Items.Ancient
{
	public class AncientDragonBag:TremorModItem
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
		//public override int BossBagNPC => ModContent.NPCType<Dragon_HeadB>();
		
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DragonHead>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Swordstorm>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AncientTimesEdge>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AncientDragonMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<AncientSoul>()));
			itemLoot.Add(ItemDropRule.Common(ItemID.HealingPotion, 1, 5, 15));
		}
	}
}
