using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Ice.Dungeon;
using Tremor.Ice.Tree;

namespace Tremor.Ice
{
	public class IceBlock:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = false;
			dustType = 80;
			drop = 664;
			soundType = 21;
			soundStyle = 2;
			AddMapEntry(new Color(84, 166, 229));
			Main.tileMerge[Type][ModContent.TileType<IceOre>()] = true;
			Main.tileMerge[Type][ModContent.TileType<VeryVeryIce>()] = true;
			Main.tileMerge[Type][ModContent.TileType<DungeonBlock>()] = true;
			Main.tileMerge[Type][TileID.IceBlock] = true;
			Main.tileMerge[Type][TileID.BreakableIce] = true;
			Main.tileMerge[Type][TileID.CorruptIce] = true;
			Main.tileMerge[Type][TileID.HallowedIce] = true;
			Main.tileMerge[Type][TileID.SnowBlock] = true;
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

		/*public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.player[Main.myPlayer];
                int style = Main.tile[i, j].TileFrameX / 15;
                string type;
                Main.player[Main.myPlayer].GetModPlayer<TremorPlayer>().ZoneIce = true;
                TremorPlayer modPlayer = Main.player[Main.myPlayer].GetModPlayer<TremorPlayer>();
                modPlayer.ZoneIce = true;
            } 
        } */

		/*public override void RandomUpdate(int i, int j)
        {
            if (Main.tile[i - 1, j].type > 0 && CanGrow(i - 1, j))
            {
                Main.tile[i - 1, j].type = (ushort)ModContent.TileType<Tiles.IceBlock>();
            }
            if (Main.tile[i + 1, j].type > 0 && CanGrow(i + 1, j))
            {
                Main.tile[i + 1, j].type = (ushort)ModContent.TileType<Tiles.IceBlock>();
            }
            if (Main.tile[i, j - 1].type > 0 && CanGrow(i, j - 1))
            {
                Main.tile[i, j - 1].type = (ushort)ModContent.TileType<Tiles.IceBlock>();
            }
            if (Main.tile[i, j + 1].type > 0 && CanGrow(i, j + 1))
            {
                Main.tile[i, j + 1].type = (ushort)ModContent.TileType<Tiles.IceBlock>();
            }
        } */
	}
}