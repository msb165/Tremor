using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class LeechingSeed:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 45000;
			Item.rare = 6;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Leeching Seed");
			// Tooltip.SetDefault("Maximum life increased by 50");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.statLifeMax2 += 50;
		}
	}
}
