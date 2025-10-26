using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class KeyofOcean:TremorModItem
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
			// DisplayName.SetDefault("Key of Ocean");
			// Tooltip.SetDefault("'Charged with the essence of ocean'");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.GoldenKey, 1);
			recipe.AddIngredient(ModContent.ItemType<SeaFragment>(), 12);
			recipe.SetResult(this);
			recipe.AddTile(134);
			recipe.AddRecipe();
		}
	}
}
