using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Souls;
using Tremor.NPCs;

namespace Tremor.Items.Dark
{
	public class DarkEmperorBag:TremorModItem
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
		public override int BossBagNPC => ModContent.NPCType<TheDarkEmperorTwo>();
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
				player.QuickSpawnItem(ModContent.ItemType<DarkEmperorMask>());
			}
			if (Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ModContent.ItemType<DrippingScythe>());
			}
			if (Main.rand.NextBool(5))
			{
				player.QuickSpawnItem(ModContent.ItemType<DelightfulClump>());
			}
			if (Main.rand.NextBool())
			{
				player.QuickSpawnItem(ModContent.ItemType<NastyJavelin>(), Main.rand.Next(30, 50));
			}
			player.QuickSpawnItem(ModContent.ItemType<SuperBigCannon>());
			player.QuickSpawnItem(ModContent.ItemType<SBCCannonballAmmo>(), Main.rand.Next(50, 150));
			player.QuickSpawnItem(ModContent.ItemType<DarkGel>(), Main.rand.Next(50, 100));
			player.QuickSpawnItem(ModContent.ItemType<SoulofFight>(), Main.rand.Next(20, 30));

			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
		}
	}
}
