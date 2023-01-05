using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Crystal;

namespace Tremor.Items.Brutallisk
{
	public class BrutalliskBag:TremorModItem
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

		public override int BossBagNPC => ModContent.NPCType<NPCs.Brutallisk>();
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<BrutalliskMask>());
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<Awakening>());
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<SnakeDevourer>());
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<LightningStaff>());
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<QuetzalcoatlStave>());
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<TreasureGlaive>());
			}
			if (Main.rand.Next(25) == 0)
			{
				player.QuickSpawnItem(ModContent.ItemType<FallenSnake>());
			}
			if (Main.rand.Next(100) == 0)
			{
				player.QuickSpawnItem(ModContent.ItemType<StrangeEgg>());
			}
			player.QuickSpawnItem(ModContent.ItemType<BrutalliskCrystal>());
			player.QuickSpawnItem(ModContent.ItemType<Aquamarine>(), Main.rand.Next(10, 18));
			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
		}
	}
}
