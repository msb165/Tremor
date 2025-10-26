using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StoneBookcase:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 42;
			Item.height = 16;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 0;
			Item.createTile = ModContent.TileType<Tiles.StoneBookcase>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone Bookcase");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3, 20);
			recipe.AddIngredient(ItemID.Book, 10);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
