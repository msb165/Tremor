using Terraria;
using Terraria.ModLoader;
using Tremor.Items.Desert;
using Tremor.Items.Sandstone;
using Tremor.NPCs;

namespace Tremor.Items
{
	public class VultureKingBag : ModItem
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
		public override int BossBagNPC => ModContent.NPCType<npcVultureKing>();
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
				player.QuickSpawnItem(ModContent.ItemType<VultureKingMask>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<CactusBow>());
			}
			if (Main.rand.NextBool(3))
			{
				player.QuickSpawnItem(ModContent.ItemType<SandKnife>());
			}
			if (Main.rand.NextBool(4))
			{
				player.QuickSpawnItem(ModContent.ItemType<VultureFeather>());
			}
			if (Main.rand.NextBool())
			{
				player.QuickSpawnItem(ModContent.ItemType<SandstoneBar>(), Main.rand.Next(10, 18));
			}
			player.QuickSpawnItem(ModContent.ItemType<DesertClaymore>());
		}
	}
}
