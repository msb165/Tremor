using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class RedBrickChimney:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 20;
			Item.height = 20;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.RedBrickChimney>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Red Brick Chimney");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.RedBrick, 10);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
