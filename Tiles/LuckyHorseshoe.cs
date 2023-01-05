using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Tremor.Tiles
{
	public class LuckyHorseshoe:TremorModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileLavaDeath[Type] = true;
		TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
		TileObjectData.newTile.Height = 1;
		TileObjectData.newTile.Width = 1;
		TileObjectData.newTile.CoordinateHeights = new[]{16};
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 36;
        TileObjectData.addTile(Type);
        dustType = 7;
	AddMapEntry(new Color(120, 85, 60));
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        if(Main.tile[i, j].TileFrameX == 0 && Main.tile[i, j].TileFrameY == 0)
        {
            Item.NewItem(null, i * 16, j * 16, 48, 48, 158);
        }
    }
}}