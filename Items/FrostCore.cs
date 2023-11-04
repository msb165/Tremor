using Terraria.ModLoader;
using Tremor.Ice.Items;

namespace Tremor.Items
{
	public class FrostCore:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 1;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Chunk");
			Tooltip.SetDefault("");
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
