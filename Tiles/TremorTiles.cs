using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.Tiles
{
	class TremorTiles : GlobalTile
    {
        public override bool Drop(int i, int j, int type)
        {
            if (type == TileID.Trees && Main.tile[i, j + 1].TileType == TileID.Grass && Main.rand.Next(40) == 0)
            {
                Item.NewItem(null, i * 16, j * 16, 32, 32, ModContent.ItemType<BirbStaff>());
            }
            return base.Drop(i, j, type);
        }				
    }
}
