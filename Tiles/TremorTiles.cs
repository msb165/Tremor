using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.Tiles
{
	class TremorTiles : GlobalTile
    {
        public override void Drop(int i, int j, int type)/* tModPorter Suggestion: Use CanDrop to decide if items can drop, use this method to drop additional items. See documentation. */
        {
            if (type == TileID.Trees && Main.tile[i, j + 1].TileType == TileID.Grass && Main.rand.NextBool(40))
            {
                Item.NewItem(null, i * 16, j * 16, 32, 32, ModContent.ItemType<BirbStaff>());
            }
        }				
    }
}
