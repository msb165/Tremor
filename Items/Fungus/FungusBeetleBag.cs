using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items.Fungus
{
	public class FungusBeetleBag : ModItem
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
		public override int BossBagNPC => ModContent.NPCType<FungusBeetle>();
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
				player.QuickSpawnItem(ModContent.ItemType<FungusBeetleMask>());
			}
			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
			player.QuickSpawnItem(ModContent.ItemType<GoldenGlowingRing>());
			player.QuickSpawnItem(ModContent.ItemType<FungusElement>(), Main.rand.Next(10, 32));
		}
	}
}
