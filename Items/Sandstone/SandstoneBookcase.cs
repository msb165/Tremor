using Terraria.ModLoader;

namespace Tremor.Items.Sandstone
{
	public class SandstoneBookcase:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 42;
			Item.height = 16;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<Tiles.SandstoneBookcase>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sandstone Bookcase");
			// Tooltip.SetDefault("");
		}

	}
}
