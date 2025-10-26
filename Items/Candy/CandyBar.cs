using Terraria.ModLoader;

namespace Tremor.Items.Candy
{
	public class CandyBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 6000;
			Item.rare = 10;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.createTile = ModContent.TileType<Tiles.CandyBarTile>();
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Candy Bar");
			// Tooltip.SetDefault("");
		}

	}
}
