using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;
using Tremor.Items.Crystal;

namespace Tremor.Tiles
{
	public class CometiteOreTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			HitSound = SoundID.Tink;
			soundStyle = 2;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			DustType = DustID.Shadowflame;
			//ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<CometiteOre>();
			AddMapEntry(new Color(0, 191, 255));
			MineResist = 8f;
			MinPick = 225;
		}

		public override bool CanExplode(int i, int j)
		{
			if(Main.tile[i, j].TileType == ModContent.TileType<Tiles.CometiteOreTile>())
			{
				return false;
			}
			return false;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			if(Main.rand.Next(10) == 0)
			{
				Item.NewItem(null, i * 16, j * 16, 16, 16, ModContent.ItemType<ChargedCrystal>());

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
	}
}