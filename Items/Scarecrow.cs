using Terraria.ModLoader;

namespace Tremor.Items
{
	public class Scarecrow:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 28;
			Item.height = 14;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 2500;
			Item.createTile = ModContent.TileType<Tiles.Scarecrow>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Scarecrow");
			// Tooltip.SetDefault("");
		}

	}
}
