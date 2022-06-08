using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RuinChest : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 32;
			item.height = 18;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 15;
			item.useStyle = 1;
			item.rare = 1;
			item.consumable = true;
			item.createTile = ModContent.TileType<Tiles.RuinChest>();
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruin Chest");
			Tooltip.SetDefault("");
		}
	}
}
