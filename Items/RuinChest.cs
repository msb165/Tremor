using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RuinChest:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 18;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.RuinChest>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Ruin Chest");
			// Tooltip.SetDefault("");
		}
	}
}
