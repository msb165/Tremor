using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.Tiles
{
	public class CollapsiumOreTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			DustType = DustID.PurpleTorch;
			HitSound = SoundID.Tink;
			soundStyle = 2;
			MineResist = 15f;
			MinPick = 250;
			AddMapEntry(new Color(255, 20, 147));
			//ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<CollapsiumOre>();

		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.9f;
			g = 0.1f;
			b = 0.5f;
		}

		public override bool CanExplode(int i, int j)
		{
			if(Main.tile[i, j].TileType == ModContent.TileType<Tiles.CollapsiumOreTile>())
			{
				return false;
			}
			return false;
		}
	}
}