using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class ParadoxTitanBag : TremorModItem
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

		////public override int BossBagNPC => ModContent.NPCType<Titan>();

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
			itemLoot.Add(ItemDropRule.Common(ItemID.HealingPotion, 1, 7, 20));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TimeTissue>(), 1, 5, 15));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Relayx>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ClockofTime>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<ParadoxTitanMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<VioleumWings>(), 20));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TheEtherealm>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<RocketWand>(), 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulFlames>(), 3));
		}
	}
}
