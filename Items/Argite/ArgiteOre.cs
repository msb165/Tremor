using Terraria.ModLoader;

namespace Tremor.Items.Argite
{
	public class ArgiteOre:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 100;
			Item.rare = 3;
			Item.createTile = ModContent.TileType<Tiles.ArgiteOre>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Argite Ore");
			// Tooltip.SetDefault("");
		}

	}
}
