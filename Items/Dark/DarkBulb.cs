using Terraria;
using Terraria.ModLoader;

namespace Tremor.Items.Dark
{
	public class DarkBulb:TremorModItem
	{
		public override void SetDefaults()
		{

			item.width = 14;
			item.height = 22;
			item.maxStack = 999;
			item.rare = 3;
			item.value = Item.buyPrice(0, 0, 10, 0);
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Bulb");
			Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 1);
			recipe.AddIngredient(ModContent.ItemType<TearsofDeath>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Charcoal>(), 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
