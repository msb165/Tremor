using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Invasion
{
	public class ParadoxTitanBag:TremorModItem
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

		public override int BossBagNPC => ModContent.NPCType<Titan>();

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
			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<ParadoxTitanMask>());
			}
			if (Main.rand.Next(20) == 0)
			{
				player.QuickSpawnItem(ModContent.ItemType<VioleumWings>());
			}
			switch (Main.rand.Next(4))
			{
				case 0:
					player.QuickSpawnItem(ModContent.ItemType<TheEtherealm>());
					break;
				case 1:
					player.QuickSpawnItem(ModContent.ItemType<RocketWand>());
					break;
				case 2:
					player.QuickSpawnItem(ModContent.ItemType<SoulFlames>());
					break;
			}
			player.QuickSpawnItem(ItemID.HealingPotion, Main.rand.Next(7, 20));
			player.QuickSpawnItem(ModContent.ItemType<TimeTissue>(), Main.rand.Next(5, 15));
			player.QuickSpawnItem(ModContent.ItemType<Relayx>());
			player.QuickSpawnItem(ModContent.ItemType<ClockofTime>());
		}
	}
}
