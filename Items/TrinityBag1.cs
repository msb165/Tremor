using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class TrinityBag1:TremorModItem
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
		public override int BossBagNPC => ModContent.NPCType<SoulofTruth>();
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
			//TODO: Sources
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<HopeMask>());
			}
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<TrustMask>());
			}
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<TruthMask>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<Banhammer>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<BestNightmare>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<HonestBlade>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<Volcannon>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<TrebleClef>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(null, ModContent.ItemType<Revolwar>());
			}
			player.QuickSpawnItem(null, ModContent.ItemType<UnpredictableСompass>());
			player.QuickSpawnItem(null, ModContent.ItemType<OmnikronBar>(), Main.rand.Next(20, 36));
			player.QuickSpawnItem(null, ModContent.ItemType<TrueEssense>(), Main.rand.Next(10, 25));
		}
	}
}
