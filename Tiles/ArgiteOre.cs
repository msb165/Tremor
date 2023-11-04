using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Tiles
{
	public class ArgiteOre:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			DustType = DustID.JungleSpore;
			HitSound = SoundID.Tink;
			soundStyle = 2;
			MinPick = 65;
			AddMapEntry(new Color(95, 201, 64));
			ItemDrop = ModContent.ItemType<Items.Argite.ArgiteOre>();
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.5f;
			b = 0.5f;
		}

		public override bool CanExplode(int i, int j)
		{
			if(Main.tile[i, j].TileType == ModContent.TileType<Tiles.ArgiteOre>())
			{
				return false;
			}
			return false;
		}
	}
}