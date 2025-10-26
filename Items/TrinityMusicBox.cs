using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TrinityMusicBox:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.useStyle = 1;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.TrinityMusicBox>();
			Item.width = 24;
			Item.height = 24;
			Item.rare = 4;
			Item.value = 100000;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Music Box (The Trinity)");
			// Tooltip.SetDefault("");
		}

	}
}
