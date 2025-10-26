using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.Items;

namespace Tremor.Tiles
{
	public class Corn:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileCut[Type] = true;
			Main.tileNoFail[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.StyleAlch);
			TileObjectData.newTile.AnchorValidTiles = new[]
			{
				2 
			};
			TileObjectData.addTile(Type);
			////ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<CornSeed>();
		}
		public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
		{
			if (i % 2 == 1)
			{
				spriteEffects = SpriteEffects.FlipHorizontally;
			}
		}

		public override bool CanDrop(int i, int j)
		{
			int stage = Main.tile[i, j].TileFrameX / 18;
			return stage == 2;
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
	}
}