using Terraria.ID;
using Terraria.ModLoader;
using Tremor.Items.Souls;

namespace Tremor.Items
{
	public class PurplePuzzleFragment:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 99;
			Item.value = 10000;
			Item.rare = 3;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Purple Puzzle Fragment");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<PhantomSoul>(), 4);
			recipe.AddIngredient(ItemID.Amethyst, 8);
			recipe.AddIngredient(ItemID.SoulofNight, 2);
			recipe.SetResult(this);
			recipe.AddTile(16);
			recipe.AddRecipe();
		}

	}
}
