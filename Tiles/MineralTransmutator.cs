using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Tremor.Tiles
{
	public class MineralTransmutator:TremorModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3);
        //TileObjectData.newTile.CoordinateHeights = new int[]{16};
        TileObjectData.addTile(Type);
        AnimationFrameHeight = 54;
        AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
	AddMapEntry(new Color(169, 169, 169));
    }

public override void AnimateTile(ref int frame, ref int frameCounter)
{
    frameCounter++;
    if(frameCounter > 8)
    {
        frameCounter = 0;
        frame++;
        frame %= 4;
    }
}

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(null, i * 16, j * 16, 32, 16, ModContent.ItemType<Items.MineralTransmutator>());
    }
}}