using Terraria.ModLoader;

namespace Tremor.Items.Chaos
{
	public class ChaosBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 500;
			Item.rare = 5;
			Item.createTile = ModContent.TileType<Tiles.ChaosBar>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Chaos Bar");
			// Tooltip.SetDefault("");
		}

	}
}
