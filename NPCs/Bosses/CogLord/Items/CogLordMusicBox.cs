using Terraria.ModLoader;
using Terraria.ID;

namespace Tremor.NPCs.Bosses.CogLord.Items
{
	public class CogLordMusicBox:TremorModItem
	{
		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Swing;
			Item.useTurn = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.autoReuse = true;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.CogLordMusicBox>();
			Item.width = 24;
			Item.height = 24;
			Item.rare = ItemRarityID.LightRed;
			Item.value = 100000;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Music Box (Cog Lord)");
			// Tooltip.SetDefault("");
		}

	}
}
