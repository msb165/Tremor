using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Tremor.ZombieEvent.Tiles
{
	public class RupicideBar:TremorModTile
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
	AddMapEntry(new Color(117, 187, 253));
        Main.tileShine[Type] = 1100;
        Main.tileSolid[Type] = true;
    }

public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
    {
        if(Main.tile[i, j].TileFrameX == 0 && Main.tile[i, j].TileFrameY == 0)
        {
            Item.NewItem(null, i * 16, j * 16, 48, 48, ModContent.ItemType<Items.RupicideBar>());
        }
    }
}}