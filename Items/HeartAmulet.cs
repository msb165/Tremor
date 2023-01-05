using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HeartAmulet:TremorModItem
	{
		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 44;
			item.value = 1000;
			item.rare = 4;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heart Amulet");
			Tooltip.SetDefault("You respawn with 80% of maximum health after death");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			TremorPlayer modPlayer = player.GetModPlayer<TremorPlayer>();
			modPlayer.heartAmulet = true;
		}
	}
}
