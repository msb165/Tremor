using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Walls
{
	public class NightmareBrickWall:ModWall
	{
		public override void SetStaticDefaults()
		{
			Main.wallHouse[Type] = true;
			//ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<Items.NightmareBrickWall>();
			AddMapEntry(new Color(90, 12, 157));
		}
	}
}