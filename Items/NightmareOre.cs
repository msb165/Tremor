using Terraria.ModLoader;

namespace Tremor.Items
{
	public class NightmareOre:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 12;
			item.value = 10000;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.rare = 11;
			item.useStyle = 1;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.NightmareOreTile>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare Ore");
			Tooltip.SetDefault("'Concentrated nightmares.'");
		}

	}
}
