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
			ItemDrop = ModContent.ItemType<Items.Doom.DoombrickWall>();
			AddMapEntry(new Color(233, 255, 0));
		}
	}
}