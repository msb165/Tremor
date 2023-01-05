using Terraria;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Brass;

namespace Tremor.NPCs.Bosses.CogLord.Items
{
	public class CogLordBag:TremorModItem
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

		public override int BossBagNPC => ModContent.NPCType<CogLord>();

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
				player.QuickSpawnItem(ModContent.ItemType<CogLordMask>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<BrassRapier>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<BrassChainRepeater>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<BrassStave>());
			}
			if (Main.rand.Next(10) == 0)
			{
				player.QuickSpawnItem(ModContent.ItemType<BrassChip>());
			}
			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
			player.QuickSpawnItem(ModContent.ItemType<HeatCore>());
			player.QuickSpawnItem(ModContent.ItemType<BrassNugget>(), Main.rand.Next(18, 32));
		}

	}
}
