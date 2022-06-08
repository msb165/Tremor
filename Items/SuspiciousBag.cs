using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Candy;
using Tremor.Items.Doom;

namespace Tremor.Items
{
	public class SuspiciousBag : ModItem
	{
		public override void SetDefaults()
		{

			item.maxStack = 999;
			item.consumable = true;
			item.width = 34;
			item.height = 34;
			item.value = 20000;

			item.rare = 11;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Suspicious Bag");
			Tooltip.SetDefault("Right click to open\n" +
"'Contains powerful treasures'");
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<Doomstone>(), Main.rand.Next(2, 5));
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<ConcentratedEther>(), Main.rand.Next(3, 10));
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<CandyBar>(), Main.rand.Next(2, 6));
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<VoidBar>(), Main.rand.Next(2, 7));
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<NightmareBar>(), Main.rand.Next(2, 6));
			}
			if (Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ModContent.ItemType<Phantaplasm>(), Main.rand.Next(3, 6));
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<CarbonSteel>(), Main.rand.Next(1, 3));
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<ClusterShard>(), Main.rand.Next(3, 36));
			}
			if (Main.rand.NextBool(8))
			{
				player.QuickSpawnItem(ModContent.ItemType<DeadTissue>(), 1);
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<ToothofAbraxas>(), Main.rand.Next(2, 4));
			}
			//if (Main.rand.Next(30) == 0)
			//{
			//	player.QuickSpawnItem(ModContent.ItemType<Burner>());
			//}
		}

	}
}
