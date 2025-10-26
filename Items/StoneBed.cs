using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class StoneBed:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 64;
			Item.height = 26;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 0;
			Item.createTile = ModContent.TileType<Tiles.StoneBed>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Stone Bed");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(3, 15);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
