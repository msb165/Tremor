using Terraria.ModLoader;

namespace Tremor.Ice.Items.Furniture
{
	public class IceBookcase:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Bookcase");
			// Tooltip.SetDefault("");
		}
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
			Item.value = 2000;
			Item.createTile = ModContent.TileType<IceBookcaseTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 20);
			recipe.AddIngredient(149, 10);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}