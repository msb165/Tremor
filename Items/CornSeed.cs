using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items
{
	class CornSeed:TremorModItem
	{
		public override void SetDefaults()
		{
			Tile tile = new Tile();

			Item.maxStack = 999;
			Item.height = 2;
			Item.width = 2;
			Item.createTile = ModContent.TileType<Tiles.Corn>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.value = 100;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.rare = 2;
			Item.consumable = true;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Corn Seeds");
			// Tooltip.SetDefault("");
		}

	}
}
