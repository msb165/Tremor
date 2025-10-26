using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Angelite;

namespace Tremor.Tiles
{
	public class AngeliteOreTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			DustType = DustID.Enchanted_Gold;
			HitSound = SoundID.Tink;
			soundStyle = 2;
			MineResist = 15f;
			MinPick = 250;
			AddMapEntry(new Color(0, 191, 255));
			//ItemDrop/* tModPorter Note: Removed. Tiles and walls will drop the item which places them automatically. Use RegisterItemDrop to alter the automatic drop if necessary. */ = ModContent.ItemType<AngeliteOre>();
		}
		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0f;
			g = 0.3f;
			b = 0.9f;
		}

		public override bool CanExplode(int i, int j)
		{
			if(Main.tile[i, j].TileType == ModContent.TileType<Tiles.AngeliteOreTile>())
			{
				return false;
			}
			return false;
		}
	}
}