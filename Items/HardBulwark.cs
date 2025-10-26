using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class HardBulwark:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;
			Item.value = 120000;
			Item.rare = 2;
			Item.defense = 5;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hard Bulwark");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Shackle, 5);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}
	}
}
