using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class GlacierWoodTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			DustType = 80;
			AddMapEntry(new Color(0, 191, 255));
			//ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<GlacierWood>();
			Main.tileMerge[Type][ModContent.TileType<IceBlock>()] = true;
			Main.tileMerge[Type][TileID.IceBlock] = true; // normal ice
			Main.tileMerge[Type][TileID.BreakableIce] = true; // thin ice
			Main.tileMerge[Type][TileID.CorruptIce] = true; // purple ice
			Main.tileMerge[Type][TileID.HallowedIce] = true; // pink ice
			Main.tileMerge[Type][TileID.SnowBlock] = true; // snow
		}

	}
}
