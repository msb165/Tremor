using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class GlacierFenceWall : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<GlacierFence>();
			AddMapEntry(new Color(36, 43, 102));
		}

	}
}
