using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Tremor.Ice.Items;

namespace Tremor.Ice
{
	public class IceOre:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileMerge[Type][161] = true;
			Main.tileMerge[Type][162] = true;
			Main.tileMerge[Type][163] = true;
			Main.tileMerge[Type][164] = true;
			Main.tileMerge[Type][147] = true;
			//Main.tileMinPick[Type] = 200;
			MinPick = 95;
			soundType = 21;
			soundStyle = 2;
			Main.tileLighted[Type] = true;
			drop = ModContent.ItemType<Icicle>();
			AddMapEntry(new Color(117, 187, 253));
		}
	}
}