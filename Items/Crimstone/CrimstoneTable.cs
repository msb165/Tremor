using Terraria.ModLoader;

namespace Tremor.Items.Crimstone
{
	public class CrimstoneTable:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
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
			Item.createTile = ModContent.TileType<Tiles.CrimstoneTable>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Crimstone Table");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(836, 8);
			recipe.AddIngredient(1257, 1);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
