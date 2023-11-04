using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class PinkGelCube:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 30;
			item.height = 24;
			item.maxStack = 99;
			item.value = 60;
			item.rare = 1;

		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Gel Cube");
			Tooltip.SetDefault("Alchemically important ingredient");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.PinkGel, 5);
			recipe.SetResult(this);
			recipe.AddTile(13);
			recipe.AddRecipe();
		}

	}
}
