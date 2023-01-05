using Terraria;
using Terraria.ModLoader;
using Tremor.NPCs;

namespace Tremor.Items.Ancient
{
	public class AncientDragonBag:TremorModItem
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
		public override int BossBagNPC => ModContent.NPCType<Dragon_HeadB>();
		
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
					player.QuickSpawnItem(ModContent.ItemType<DragonHead>());
					break;
				case 1:
					player.QuickSpawnItem(ModContent.ItemType<Swordstorm>());
					break;
				case 2:
					player.QuickSpawnItem(ModContent.ItemType<AncientTimesEdge>());
					break;
			}

			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<AncientDragonMask>());
			}

			if (Main.hardMode)
			{
				player.TryGettingDevArmor();
			}
			player.QuickSpawnItem(ModContent.ItemType<AncientSoul>());
			player.QuickSpawnItem(188, Main.rand.Next(5, 15));
		}

	}
}
