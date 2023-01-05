using Terraria.ModLoader;
using Tremor.Items.Wood;

namespace Tremor.Items
{
	public class HardArmor:TremorModItem
	{

		public override void SetDefaults()
		{

			item.width = 34;
			item.height = 34;
			item.value = 150000;
			item.rare = 3;
			item.defense = 8;
			item.accessory = true;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hard Armor");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<HardBulwark>(), 1);
			recipe.AddIngredient(ModContent.ItemType<WoodenFrame>(), 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
