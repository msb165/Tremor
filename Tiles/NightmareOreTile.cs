using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.Tiles
{
	public class NightmareOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
                                   soundType = 21;
                                   soundStyle = 2;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			dustType = ModContent.DustType<Dusts.NightmareFlame>();
			drop = ModContent.ItemType<NightmareOre>();
			AddMapEntry(new Color(90, 0, 157));
mineResist = 12f;
minPick = 225;
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

  public override bool CanExplode(int i, int j)
  {
   if (Main.tile[i, j].type == ModContent.TileType<Tiles.NightmareOreTile>())
   {
    return false;
   }
   return false;
  }
	}
}