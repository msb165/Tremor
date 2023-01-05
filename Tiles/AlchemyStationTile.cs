using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.Items.Alchemist;

namespace Tremor.Tiles
{
	public class AlchemyStationTile:TremorModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 36;
        TileObjectData.addTile(Type);
        dustType = 7;
        adjTiles = new[]{13};
		ModTranslation name = CreateMapEntryName();
		name.SetDefault("Alchemy Station");		
	AddMapEntry(new Color(65, 43, 9), name);
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        if(frameX == 0)
        {
            Item.NewItem(null, i * 16, j * 16, 48, 48, ModContent.ItemType<AlchemyStation>());
        }
    }
}}