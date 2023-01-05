using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Enums;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Tremor.Ice
{
	public class IceColl2:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileCut[Type] = false;
			//Main.tileAlch[Type] = true;
			Main.tileNoFail[Type] = true;
			//Main.tileLavaDeath[Type] = true;
			//dustType = -1;
			//disableSmartCursor = true;
			//AddMapEntry(new Color(13, 88, 130), "Banner");
			//TileObjectData.newTile.Width = 1;
			//TileObjectData.newTile.Height = 2;
			//TileObjectData.newTile.Origin = Point16.Zero;
			//TileObjectData.newTile.UsesCustomCanPlace = true;
			//TileObjectData.newTile.CoordinateHeights = new int[]
			//{
			//	20
			//};
			//TileObjectData.newTile.CoordinateWidth = 16;
			//TileObjectData.newTile.CoordinatePadding = 2;
			//TileObjectData.newTile.DrawYOffset = -1;
			//TileObjectData.newTile.StyleHorizontal = true;
			//TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.AlternateTile, TileObjectData.newTile.Width, 0);
			//TileObjectData.newTile.WaterPlacement = LiquidPlacement.NotAllowed;
			//TileObjectData.newTile.LavaDeath = true;
			//TileObjectData.newTile.LavaPlacement = LiquidPlacement.NotAllowed;
			//TileObjectData.addBaseTile(out TileObjectData.StyleAlch);
			Main.tileWaterDeath[Type] = false;
			TileObjectData.newTile.LavaPlacement = LiquidPlacement.NotAllowed;
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleAlch);
			TileObjectData.newTile.AnchorValidTiles = new[]
			{
				ModContent.TileType<IceBlock>()
			};
			dustType = ModContent.DustType<IceDust>();
			soundType = 21;
			soundStyle = 2;
			TileObjectData.newTile.WaterDeath = false;
			TileObjectData.addTile(Type);
			//drop = ModContent.ItemType()
		}
		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override void RandomUpdate(int i, int j)
		{
			if (Main.tile[i, j].TileFrameX == 0)
			{
				Main.tile[i, j].TileFrameX += 18;
			}
			else if (Main.tile[i, j].TileFrameX == 18)
			{
				Main.tile[i, j].TileFrameX += 18;
			}
		}
		//public override void RightClick(int i, int j)
		//{
		//	base.RightClick(i, j);
		//}
	}
}
