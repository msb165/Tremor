using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	public class DarkEmperorTrophy:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 50000;
			Item.createTile = ModContent.TileType<Tiles.DarkEmperorTrophy>();
			Item.placeStyle = 0;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dark Emperor Trophy");
			// Tooltip.SetDefault("");
		}

	}
}
