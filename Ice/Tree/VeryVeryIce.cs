using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Ice.Tree
{
	public class VeryVeryIce:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			//Main.tileMerge[Type][ModContent.TileType<Tiles.TremorTree>()] = true;
			Main.tileMerge[Type][ModContent.TileType<IceBlock>()] = true;
			Main.tileMerge[Type][161] = true;
			Main.tileMerge[Type][162] = true;
			Main.tileMerge[Type][163] = true;
			Main.tileMerge[Type][164] = true;
			Main.tileMerge[Type][147] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			//Main.tileMinPick[Type] = 200;
			DustType = DustID.Ice;
			HitSound = SoundID.Tink;
			soundStyle = 2;
			Main.tileLighted[Type] = true;
			AddMapEntry(new Color(104, 155, 195));

			//TODO: [Skipped for 1.4] Fix Trees
			//SetModTree(new TremorTree());
			
			ItemDrop = ModContent.ItemType<IceBlockB>();
		}

		public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
		{
			Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
			Tile tile = Main.tile[i, j];
			int height = tile.TileFrameY == 36 ? 18 : 16;
			int animate = 0;
			if (tile.TileFrameY >= 56)
			{
				animate = Main.tileFrame[Type] * AnimationFrameHeight;
			}
			Texture2D texture = TextureAssets.Tile[Type].Value;
			Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.TileFrameX, tile.TileFrameY + animate, 16, height), Lighting.GetColor(i, j), 0f, default(Vector2), 1f, SpriteEffects.None, 0f);
			return false;
		}
		public override void RandomUpdate(int i, int j)
		{
			if (Main.tile[i - 1, j].TileType == TileID.SnowBlock && CanGrow(i - 1, j))
			{
				Main.tile[i - 1, j].TileType = (ushort)ModContent.TileType<IceBlock>();
			}
			if (Main.tile[i + 1, j].TileType == TileID.SnowBlock && CanGrow(i + 1, j))
			{
				Main.tile[i + 1, j].TileType = (ushort)ModContent.TileType<IceBlock>();
			}
			if (Main.tile[i, j - 1].TileType == TileID.SnowBlock && CanGrow(i, j - 1))
			{
				Main.tile[i, j - 1].TileType = (ushort)ModContent.TileType<IceBlock>();
			}
			if (Main.tile[i, j + 1].TileType == TileID.SnowBlock && CanGrow(i, j + 1))
			{
				Main.tile[i, j + 1].TileType = (ushort)ModContent.TileType<IceBlock>();
			}
		}

		public bool CanGrow(int i, int j)
		{
			bool flag = false;
			for (int x = 0; x < 3; x++)
				for (int y = 0; y < 3; y++)
				{
					if (!Main.tile[i - 1 + x, j - 1 + y].active())
						flag = true;
				}
			return flag;
		}


		//TODO: [Skipped for 1.4] Fix Trees
		//public override int SaplingGrowthType(ref int style)
		//{
		//	style = 0;
		//	return ModContent.TileType<TremorSapling>();
		//}
	}
}