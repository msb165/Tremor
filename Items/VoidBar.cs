using Terraria.ModLoader;

namespace Tremor.Items
{
	public class VoidBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 11;
			Item.createTile = ModContent.TileType<Tiles.VoidBarTile>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Void Bar");
			// Tooltip.SetDefault("");
		}

	}
}
