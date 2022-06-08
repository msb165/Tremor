using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class TrinityBag3 : ModItem
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
		public override int BossBagNPC => ModContent.NPCType<SoulofHope>();
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
				player.QuickSpawnItem(ModContent.ItemType<HopeMask>());
			}
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<TrustMask>());
			}
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<TruthMask>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<Banhammer>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<BestNightmare>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<HonestBlade>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<Volcannon>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<TrebleClef>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<Revolwar>());
			}
			player.QuickSpawnItem(ModContent.ItemType<UnpredictableСompass>());
			player.QuickSpawnItem(ModContent.ItemType<OmnikronBar>(), Main.rand.Next(20, 36));
			player.QuickSpawnItem(ModContent.ItemType<TrueEssense>(), Main.rand.Next(10, 25));
		}
	}
}
