using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.NPCs.Bosses.NovaPillar.Items.Placeable;

namespace Tremor.NPCs.Bosses.NovaPillar.Tiles
{
	public class NovaMonolithTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2xX);
			TileObjectData.newTile.Height = 3;
			TileObjectData.newTile.Origin = new Point16(1, 2);
			TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 18 };
			TileObjectData.addTile(Type);
			AddMapEntry(new Color(75, 139, 166));
			dustType = 1;
			AnimationFrameHeight = 56;
			disableSmartCursor = true;
			adjTiles = new int[] { TileID.LunarMonolith };
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(null, i * 16, j * 16, 32, 48, ModContent.ItemType<NovaMonolith>());
		}

		public override void NearbyEffects(int i, int j, bool closer)
		{
			if (Main.tile[i, j].TileFrameY >= 56)
			{
				TremorPlayer modPlayer = Main.LocalPlayer.GetModPlayer<TremorPlayer>();
				modPlayer.NovaMonolith = true;
			}
		}

		public override void AnimateTile(ref int frame, ref int frameCounter)
		{
			frame = Main.tileFrame[TileID.LunarMonolith];
			frameCounter = Main.tileFrameCounter[TileID.LunarMonolith];
		}

		public override bool PreDraw(int i, int j, SpriteBatch spriteBatch)
		{
			Tile tile = Main.tile[i, j];
			Texture2D texture;
			//TODO: canDrawColorTile and tileAlt
			//if (Main.canDrawColorTile(i, j))
			//{
			//	texture = TextureAssets.tileAlt[Type, tile.color()];
			//}
			//else
			{
				texture = TextureAssets.Tile[Type].Value;
			}
			Vector2 zero = new Vector2(Main.offScreenRange, Main.offScreenRange);
			if (Main.drawToScreen)
			{
				zero = Vector2.Zero;
			}
			int height = tile.TileFrameY == 36 ? 18 : 16;
			int animate = 0;
			if (tile.TileFrameY >= 56)
			{
				animate = Main.tileFrame[Type] * AnimationFrameHeight;
			}
			Main.spriteBatch.Draw(texture, new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.TileFrameX, tile.TileFrameY + animate, 16, height), Lighting.GetColor(i, j), 0f, default(Vector2), 1f, SpriteEffects.None, 0f);
			Main.spriteBatch.Draw(Mod.GetTexture("NPCs/Bosses/NovaPillar/Tiles/NovaMonolithTile_Glowmask"), new Vector2(i * 16 - (int)Main.screenPosition.X, j * 16 - (int)Main.screenPosition.Y) + zero, new Rectangle(tile.TileFrameX, tile.TileFrameY + animate, 16, height), Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
			return false;
		}

		public override bool RightClick(int i, int j)
		{
			SoundEngine.PlaySound(SoundID.Mech, new Vector2(i * 16, j * 16));//Variant 0
			HitWire(i, j);
			return true;
		}

		public override void MouseOver(int i, int j)
		{
			Player player = Main.LocalPlayer;
			player.noThrow = 2;
			player.cursorItemIconEnabled = true;
			player.cursorItemIconID = ModContent.ItemType<NovaMonolith>();
		}

		public override void HitWire(int i, int j)
		{
			int x = i - (Main.tile[i, j].TileFrameX / 18) % 2;
			int y = j - (Main.tile[i, j].TileFrameY / 18) % 3;
			for (int l = x; l < x + 2; l++)
			{
				for (int m = y; m < y + 3; m++)
				{
					//if (Main.tile[l, m] == null)
					//{
					//	Main.tile[l, m] = new Tile();
					//}
					if (Main.tile[l, m].active() && Main.tile[l, m].TileType == Type)
					{
						if (Main.tile[l, m].TileFrameY < 56)
						{
							Main.tile[l, m].TileFrameY += 56;
						}
						else
						{
							Main.tile[l, m].TileFrameY -= 56;
						}
					}
				}
			}
			if (Wiring.running)
			{
				Wiring.SkipWire(x, y);
				Wiring.SkipWire(x, y + 1);
				Wiring.SkipWire(x, y + 2);
				Wiring.SkipWire(x + 1, y);
				Wiring.SkipWire(x + 1, y + 1);
				Wiring.SkipWire(x + 1, y + 2);
			}
			NetMessage.SendTileSquare(-1, x, y + 1, 3);
		}
	}
}