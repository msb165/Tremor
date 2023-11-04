using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class EvilCornBag:TremorModItem
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
		public override int BossBagNPC => ModContent.NPCType<EvilCorn>();
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
				player.QuickSpawnItem(ModContent.ItemType<EvilCornMask>());
			}
			if (Main.rand.Next(10) == 0)
			{
				player.QuickSpawnItem(ModContent.ItemType<EvilCornTrophy>());
			}
			if (Main.rand.NextBool())
			{
				player.QuickSpawnItem(ModContent.ItemType<CornHeater>());
			}
			if (Main.rand.NextBool(2))
			{
				player.QuickSpawnItem(ModContent.ItemType<GrayKnightHelmet>());
			}
			if (Main.rand.NextBool(2))
			{
				player.QuickSpawnItem(ModContent.ItemType<GrayKnightBreastplate>());
			}
			if (Main.rand.NextBool(2))
			{
				player.QuickSpawnItem(ModContent.ItemType<KnightGreaves>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<CornSword>());
			}
			if (!Main.LocalPlayer.HasItem(ModContent.ItemType<FarmerShovel>()))
			{
				player.QuickSpawnItem(ModContent.ItemType<FarmerShovel>());
			}
			player.QuickSpawnItem(ModContent.ItemType<Corn>(), Main.rand.Next(25, 48));
			player.QuickSpawnItem(ModContent.ItemType<CornJavelin>(), Main.rand.Next(15, 45));
		}

	}
}
