using Terraria.ModLoader;

namespace Tremor.Ice.Items.Furniture
{
	public class IcePiano:TremorModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Glacier Wood Piano");
			// Tooltip.SetDefault("");
		}
		public override void SetDefaults()
		{
			Item.width = 62;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<IcePianoTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(154, 4);
			recipe.AddIngredient(ModContent.ItemType<GlacierWood>(), 15);
			recipe.AddIngredient(149);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}