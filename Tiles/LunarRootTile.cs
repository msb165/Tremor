using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.Items;

namespace Tremor.Tiles
{
	public class LunarRootTile:TremorModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
        //TileObjectData.newTile.StyleHorizontal = true;
        TileObjectData.newTile.StyleWrapLimit = 36;
        TileObjectData.addTile(Type);
        DustType = DustID.WoodFurniture;
        TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.Table, TileObjectData.newTile.Width, 0);
	AddMapEntry(new Color(120, 85, 60));
			MineResist = 8f;
			MinPick = 200;
    }

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        if(Main.rand.NextBool())
        {
            Item.NewItem(null, i * 16, j * 16, 16, 16, 3460, Main.rand.Next(1,3));
        }
        if(Main.rand.NextBool(2))
        {
            Item.NewItem(null, i * 16, j * 16, 16, 16, ModContent.ItemType<LunarRoot>(), Main.rand.Next(1,5));
        }
        if(Main.rand.NextBool(4))
        {
            Item.NewItem(null, i * 16, j * 16, 16, 16, ModContent.ItemType<NightCore>(), Main.rand.Next(1,2));
            
        }
    }

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.0f;
			b = 0.7f;
		}
}}