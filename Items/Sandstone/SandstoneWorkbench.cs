using Terraria.ModLoader;

namespace Tremor.Items.Sandstone
{
	public class SandstoneWorkbench:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
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
			Item.createTile = ModContent.TileType<Tiles.SandstoneWorkbench>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Sandstone Workbench");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(607, 10);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
