using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Alchemist.Flasks;
using Tremor.Items.Dark;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class WallofShadowBag : ModItem
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
		public override int BossBagNPC => ModContent.NPCType<WallOfShadow>();
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
			switch (Main.rand.Next(4))
			{
				case 0:
					player.QuickSpawnItem(ModContent.ItemType<HeavyBeamCannon>());
					break;
				case 1:
					player.QuickSpawnItem(ModContent.ItemType<Bolter>());
					break;
				case 2:
					player.QuickSpawnItem(ModContent.ItemType<StrikerBlade>());
					break;
			}

			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<WallofShadowMask>());
			}

			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
			player.QuickSpawnItem(ModContent.ItemType<WallOfShadowsFlask>());
			player.QuickSpawnItem(ModContent.ItemType<DarknessCloth>(), Main.rand.Next(8, 15));
			player.QuickSpawnItem(499, Main.rand.Next(5, 15));
		}

	}
}
