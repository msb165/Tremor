using Terraria.ModLoader;
using Tremor.Items.Flesh;

namespace Tremor.ZombieEvent.Items
{
	public class NecromaniacWorkbench:TremorModItem
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
			Item.value = 200;
			Item.createTile = ModContent.TileType<Tiles.NecromaniacWorkbenchTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Necromaniac Workbench");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<FleshWorkstation>(), 1);
			recipe.AddIngredient(ModContent.ItemType<RupicideBar>(), 5);
			recipe.AddIngredient(ModContent.ItemType<WickedHeart>(), 1);
			recipe.AddIngredient(ModContent.ItemType<BookofRevelations>(), 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
