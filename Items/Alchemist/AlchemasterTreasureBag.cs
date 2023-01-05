using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Alchemist.Flasks;
using Tremor.NPCs;

namespace Tremor.Items.Alchemist
{
	public class AlchemasterTreasureBag:TremorModItem
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
		public override int BossBagNPC => ModContent.NPCType<Alchemaster>();
		
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
				player.QuickSpawnItem(ModContent.ItemType<AlchemasterMask>());
			}
			if (Main.rand.Next(10) == 0)
			{
				player.QuickSpawnItem(ModContent.ItemType<AlchemasterTrophy>());
			}
			if (Main.rand.NextBool())
			{
				player.QuickSpawnItem(ModContent.ItemType<PlagueFlask>(), Main.rand.Next(30, 78));
			}
			if (Main.rand.NextBool())
			{
				player.QuickSpawnItem(ModContent.ItemType<SparkingFlask>(), Main.rand.Next(30, 78));
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<TheGlorch>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<BadApple>());
			}
			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
			player.QuickSpawnItem(ModContent.ItemType<GoldenStar>());
			player.QuickSpawnItem(ModContent.ItemType<LongFuse>());
		}
	}
}
