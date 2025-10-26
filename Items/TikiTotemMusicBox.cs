using Terraria.ModLoader;

namespace Tremor.Items
{
	public class TikiTotemMusicBox:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.useStyle = 1;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.TikiTotemMusicBox>();
			Item.width = 24;
			Item.height = 24;
			Item.rare = 4;
			Item.value = 100000;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Music Box (Tiki Totem)");
			// Tooltip.SetDefault("");
		}

	}
}
