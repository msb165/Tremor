using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.Tiles
{
	public class GloomstoneBrickTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<GloomstoneBrick>();
                                   soundType = 21;
                                   soundStyle = 2;
			AddMapEntry(new Color(36, 118, 174));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

	}
}