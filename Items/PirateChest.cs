using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PirateChest:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.maxStack = 999;
			Item.consumable = true;
			Item.width = 34;
			Item.height = 34;
			Item.value = 20000;

			Item.rare = 5;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Pirate Chest");
			/* Tooltip.SetDefault("Right click to open\n" +
"'Contains precious things'"); */
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (Main.rand.Next(10) == 0)
			{
				player.QuickSpawnItem(2854);
			}
			if (Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(672);
			}
			if (Main.rand.Next(25) == 0)
			{
				player.QuickSpawnItem(905);
			}
			if (Main.rand.Next(15) == 0)
			{
				player.QuickSpawnItem(855); ;
			}
			if (Main.rand.Next(10) == 0)
			{
				player.QuickSpawnItem(854);
			}
			if (Main.rand.Next(15) == 0)
			{
				player.QuickSpawnItem(3033);
			}
			if (Main.rand.NextBool(6))
			{
				player.QuickSpawnItem(ModContent.ItemType<HandCannon>());
			}
			if (Main.rand.NextBool(6))
			{
				player.QuickSpawnItem(ModContent.ItemType<PirateFlag>());
			}
			if (Main.rand.NextBool())
			{
				player.QuickSpawnItem(73, Main.rand.Next(9, 18));
			}
			if (Main.rand.NextBool(2))
			{
				player.QuickSpawnItem(19, Main.rand.Next(14, 19)); ;
			}
			if (Main.rand.NextBool(2))
			{
				player.QuickSpawnItem(706, Main.rand.Next(14, 19)); ;
			}
		}

	}
}
