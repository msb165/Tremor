using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Tremor.Tiles;
using Tremor.ZombieEvent.Items;

namespace Tremor.ZombieEvent.Tiles
{
	public class NecromaniacWorkbenchTile:TremorModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
			TileObjectData.newTile.CoordinateHeights = new[]{ 16, 16 };
			TileObjectData.addTile(Type);
		LocalizedText name = CreateMapEntryName();
		// name.SetDefault("Necromaniac Workbench");			
			AddMapEntry(new Color(0, 77, 255), name);
                       AdjTiles = new[]{ModContent.TileType<FleshWorkstationTile>()};
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(null, i * 16, j * 16, 32, 16, ModContent.ItemType<NecromaniacWorkbench>());
		}
	}
}