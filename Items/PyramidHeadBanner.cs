using Terraria;
using Terraria.ModLoader;
using Tremor.Tiles;

namespace Tremor.Items
{
	public class PyramidHeadBanner:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 10;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.rare = 1;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.createTile = ModContent.TileType<MonsterBanner>();
			item.placeStyle = 38;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pyramid Head Banner");
			Tooltip.SetDefault("");
		}

	}
}
