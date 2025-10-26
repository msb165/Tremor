using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Ice.Dungeon
{
	public class DungeonBlock:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileMerge[Type][ModContent.TileType<IceBlock>()] = true;
			Main.tileMerge[Type][ModContent.TileType<Ice.Tree.VeryVeryIce>()] = true;
			Main.tileMerge[Type][147] = true;
			DustType = ModContent.DustType<IceDust>();
			////ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<DungeonBlockItem>();
			AddMapEntry(new Color(70, 156, 213));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.5f;
			b = 0.5f;
		}
	}
}