using Terraria.ModLoader;

namespace Tremor.Items.Sandstone
{
	public class SandstoneBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 200;
			Item.rare = 2;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.createTile = ModContent.TileType<Tiles.SandstoneBar>();
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dune Bar");
			// Tooltip.SetDefault("");
		}

	}
}
