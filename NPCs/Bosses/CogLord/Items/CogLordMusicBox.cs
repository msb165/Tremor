using Terraria.ModLoader;
using Terraria.ID;

namespace Tremor.NPCs.Bosses.CogLord.Items
{
	public class CogLordMusicBox:TremorModItem
	{
		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.Swing;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.CogLordMusicBox>();
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.LightRed;
			item.value = 100000;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Box (Cog Lord)");
			Tooltip.SetDefault("");
		}

	}
}
