using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class BottledGlue:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 14;
			Item.height = 22;
			Item.maxStack = 999;
			Item.rare = 3;
			Item.value = Item.buyPrice(0, 0, 5, 0);
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Bottled Glue");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.BottledWater, 1);
			recipe.AddIngredient(ModContent.ItemType<LightBulb>(), 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
