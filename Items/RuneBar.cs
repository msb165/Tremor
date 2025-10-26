using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RuneBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 4;
			Item.createTile = ModContent.TileType<Tiles.RuneBarTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Rune Bar");
			// Tooltip.SetDefault("");
		}

	}
}
