using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Wood
{
	public class PalmWoodArmchair:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 42;
			Item.height = 32;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.PalmWoodArmchair>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Palm Wood Armchair");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.PalmWood, 15);
			recipe.AddIngredient(ItemID.Silk, 6);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
