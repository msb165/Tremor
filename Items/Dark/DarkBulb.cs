using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	public class DarkBulb:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 14;
			Item.height = 22;
			Item.maxStack = 999;
			Item.rare = 3;
			Item.value = Item.buyPrice(0, 0, 10, 0);
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Dark Bulb");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TearsofDeath>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Charcoal>(), 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
