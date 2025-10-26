using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StoneBathtub:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 64;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 0;
			Item.createTile = ModContent.TileType<Tiles.StoneBathtub>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone Bathtub");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3, 14);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
