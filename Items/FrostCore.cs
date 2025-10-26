using Terraria.ModLoader;
using Tremor.Ice.Items;

namespace Tremor.Items
{
	public class FrostCore:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Frost Chunk");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Icicle>(), 4);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
