using Terraria.ModLoader;
using Tremor.Items;

namespace Tremor.ZombieEvent.Items
{
	public class BowBlueprint:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 10000;
			Item.rare = 6;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bow Blueprint");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<TornPapyrus>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TearsofDeath>(), 1);
			recipe.AddIngredient(ModContent.ItemType<CursedInk>(), 1);
			recipe.AddTile(ModContent.TileType<Tiles.NecromaniacWorkbenchTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
