using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class GlacierFenceWall : ModWall
	{
		public override void SetStaticDefaults()
		{
			Main.wallHouse[Type] = true;
			ItemDrop = ModContent.ItemType<GlacierFence>();
			AddMapEntry(new Color(36, 43, 102));
		}

	}
}
