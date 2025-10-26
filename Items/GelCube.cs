using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GelCube:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 60;
			Item.rare = 1;

		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gel Cube");
			// Tooltip.SetDefault("Alchemically important ingredient");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Gel, 5);
			recipe.SetResult(this);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}

	}
}
