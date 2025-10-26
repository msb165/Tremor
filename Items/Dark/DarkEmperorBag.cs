using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs;

namespace Tremor.Items.Dark
{
	public class DarkEmperorBag:TremorModItem
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
		//public override int BossBagNPC => ModContent.NPCType<TheDarkEmperorTwo>();
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
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DarkEmperorMask>(), 7));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DrippingScythe>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DelightfulClump>(), 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<NastyJavelin>(), 2, 30, 50));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SuperBigCannon>()));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SBCCannonballAmmo>(), 1, 50, 100));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulofFight>(), 1, 20, 30));
		}
	}
}
