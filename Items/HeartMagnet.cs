using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HeartMagnet:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 44;

			Item.value = 12000;
			Item.rare = 3;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Heart Magnet");
			// Tooltip.SetDefault("Increased heart pickup range");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.lifeMagnet = true;
		}
	}
}
