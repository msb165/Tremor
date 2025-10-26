using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GreatAnvil:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 50;
			Item.height = 26;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;

			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.GreatAnvilTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Great Anvil");
			// Tooltip.SetDefault("Allows to produce heavy weapons");
		}

	}
}
