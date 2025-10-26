using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightmareOre:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.value = 10000;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = 11;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.NightmareOreTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Nightmare Ore");
			// Tooltip.SetDefault("'Concentrated nightmares.'");
		}

	}
}
