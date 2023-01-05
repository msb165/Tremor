using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Chaos;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class PixieQueenBag:TremorModItem
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
		public override int BossBagNPC => ModContent.NPCType<PixieQueen>();
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
				player.QuickSpawnItem(ModContent.ItemType<PixieQueenMask>());
			}
			if (Main.rand.NextBool(6))
			{
				player.QuickSpawnItem(ModContent.ItemType<EtherealFeather>());
			}
			if (Main.rand.NextBool(6))
			{
				player.QuickSpawnItem(ModContent.ItemType<PixiePulse>());
			}
			if (Main.rand.NextBool(6))
			{
				player.QuickSpawnItem(ModContent.ItemType<HeartMagnet>());
			}
			if (Main.rand.NextBool(6))
			{
				player.QuickSpawnItem(ModContent.ItemType<DopelgangerCandle>());
			}
			player.QuickSpawnItem(ModContent.ItemType<GlorianaWrath>());
			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
			player.QuickSpawnItem(ModContent.ItemType<ChaosBar>(), Main.rand.Next(15, 25));
		}

	}
}
