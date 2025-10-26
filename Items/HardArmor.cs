using Terraria.ModLoader;
using Tremor.Items.Wood;

namespace Tremor.Items
{
	public class HardArmor:TremorModItem
	{

		public override void SetDefaults()
		{

			Item.width = 34;
			Item.height = 34;
			Item.value = 150000;
			Item.rare = 3;
			Item.defense = 8;
			Item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Hard Armor");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<HardBulwark>(), 1);
			recipe.AddIngredient(ModContent.ItemType<WoodenFrame>(), 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
