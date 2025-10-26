using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class KeyofSands:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 26;
			Item.maxStack = 99;
			Item.height = 26;

			Item.rare = 0;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Key of Sands");
			// Tooltip.SetDefault("'Charged with the essence of sands'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GoldenKey, 1);
			recipe.AddIngredient(3783, 6);
			recipe.AddIngredient(ItemID.SandBlock, 10);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
