using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Walls
{
	public class DoombrickWall:ModWall
	{
		public override void SetStaticDefaults()
		{
			Main.wallHouse[Type] = true;
			//ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<Items.Doom.DoombrickWall>();
			AddMapEntry(new Color(233, 255, 0));
		}
	}
}