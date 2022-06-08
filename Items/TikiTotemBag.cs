using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class TikiTotemBag : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;

			item.rare = 9;
			item.expert = true;
		}
		public override int BossBagNPC => ModContent.NPCType<TikiTotem>();
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tiki Totem Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			(int type,int chance,int quantity)[] drops = new[]
			{
				// item, chance, stack
				(ModContent.ItemType<ToxicBlade>(), 3, 1),
				(ModContent.ItemType<JungleAlloy>(), 1, 1),
				(ModContent.ItemType<TikiSkull>(), 1, 1), // only specific one
				(ModContent.ItemType<PickaxeofBloom>(), 3, 1),
				(ModContent.ItemType<ToxicHilt>(), 4, 1),
				(ModContent.ItemType<AngryTotemMask>(), 7, 1),
				(ModContent.ItemType<HappyTotemMask>(), 7, 1),
				(ModContent.ItemType<IndifferentTotemMask>(), 7, 1),
				(ItemID.HealingPotion, 1, Main.rand.Next(5, 16)),
				(ItemID.ManaPotion, 1, Main.rand.Next(5, 16)),
			};

			for (int i = 0; i < drops.GetUpperBound(0); i++)
			{
				if (Main.rand.NextBool(drops[i].chance))
				{
					player.QuickSpawnItem(drops[i].type, drops[i].quantity);
				}
			}
		}
	}
}
