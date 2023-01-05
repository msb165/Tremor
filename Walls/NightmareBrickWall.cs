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
			ItemDrop = ModContent.ItemType<Items.NightmareBrickWall>();
			AddMapEntry(new Color(90, 12, 157));
		}
	}
}