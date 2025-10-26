using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor
{
	class TremorGlobalTile : GlobalTile
	{
		public override void Drop(int i, int j, int type)/* tModPorter Suggestion: Use CanDrop to decide if items can drop, use this method to drop additional items. See documentation. */
		{
			if (type == TileID.Emerald)
			{
				if (Main.rand.NextBool(20))
				{
					Item.NewItem(null, i * 16, j * 16, 48, 32, ModContent.ItemType<Items.EmeraldStone>());
				}
			}
		}
	}
}
