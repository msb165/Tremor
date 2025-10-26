using Terraria.ModLoader;

namespace Tremor.Items
{
	public class FrostoneOre:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 16;
			Item.height = 16;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.rare = 7;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.FrostoneOreTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frostone Ore");
			// Tooltip.SetDefault("");
		}

	}
}
