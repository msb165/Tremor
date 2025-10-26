using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Tremor.Tiles
{
	public class DevilForge:TremorModTile
{
    public override void SetDefaults()
    {
        Main.tileFrameImportant[Type] = true;
        Main.tileNoAttach[Type] = true;
        Main.tileTable[Type] = true;
        Main.tileLavaDeath[Type] = true;
        TileObjectData.newTile.CopyFrom(TileObjectData.Style4x2);
        TileObjectData.addTile(Type);
        AnimationFrameHeight = 36;
        AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
		LocalizedText name = CreateMapEntryName();
		// name.SetDefault("Devil Forge");		
	AddMapEntry(new Color(179, 146, 113), name);
    }

public override void AnimateTile(ref int frame, ref int frameCounter)
{
    frameCounter++;
    if(frameCounter > 6)
    {
        frameCounter = 0;
        frame++;
        frame %= 4;
    }
}

    public override void KillMultiTile(int i, int j, int frameX, int frameY)
    {
        Item.NewItem(null, i * 16, j * 16, 32, 16, ModContent.ItemType<Items.DevilForge>());
    }
}}