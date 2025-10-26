using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EyeMonolith:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 62;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;

			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 3;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<Tiles.EyeMonolithTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Eye Monolith");
			// Tooltip.SetDefault("15% increased minion damage if placed");
		}

	}
}
