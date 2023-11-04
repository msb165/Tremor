using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Doom;

namespace Tremor.Tiles
{
	public class DoombrickTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			DustType = ModContent.DustType<Dusts.DoomFlame>();
			ItemDrop = ModContent.ItemType<Doombrick>();
			HitSound = SoundID.Tink;
			soundStyle = 2;
			AddMapEntry(new Color(204, 255, 0));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.0f;
			g = 0.5f;
			b = 0.7f;
		}
	}
}