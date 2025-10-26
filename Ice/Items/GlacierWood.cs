using Terraria.ModLoader;

namespace Tremor.Ice.Items
{
	public class GlacierWood:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.value = 1;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = 1;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<GlacierWoodTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWoodWall>(), 4);
			recipe.SetResult(this, 1);
			recipe.AddTile(18);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierFence>(), 4);
			recipe.SetResult(this, 1);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
