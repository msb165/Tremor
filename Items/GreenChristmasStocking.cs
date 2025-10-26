using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GreenChristmasStocking:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 22;
			Item.height = 26;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.GreenChristmasStocking>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.value = 100;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Green Christmas Stocking");
			// Tooltip.SetDefault("");
		}

	}
}
