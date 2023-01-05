using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.Tiles
{
	public class NightmareBrickTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = ModContent.DustType<Dusts.NightmareFlame>();
			drop = ModContent.ItemType<NightmareBrick>();
                                   soundType = 21;
                                   soundStyle = 2;
			AddMapEntry(new Color(90, 0, 157));
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
	}
}