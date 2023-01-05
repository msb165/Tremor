using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor
{
	class TremorGlobalTile : GlobalTile
	{
		public override bool Drop(int i, int j, int type)
		{
			if (type == TileID.Emerald)
			{
				if (Main.rand.Next(20) == 1)
				{
					Item.NewItem(null, i * 16, j * 16, 48, 32, ModContent.ItemType<Items.EmeraldStone>());
					return false;
				}
			}
			return true;
		}
	}
}
