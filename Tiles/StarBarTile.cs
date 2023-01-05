using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.Items;

namespace Tremor.Tiles
{
	public class StarBarTile:TremorModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileSolidTop[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
        TileObjectData.newTile.Height = 1;
        TileObjectData.newTile.CoordinateHeights = new[]{16};
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 111;
        TileObjectData.addTile(Type);
	AddMapEntry(new Color(255, 215, 0));
        Main.tileShine[Type] = 1100;
        Main.tileSolid[Type] = true;
    }

        public override bool Drop(int i, int j)
        {
            Item.NewItem(null, i * 16, j * 16, 32, 32, ModContent.ItemType<StarBar>());
            return true;
        }
}}