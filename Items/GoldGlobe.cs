using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GoldGlobe:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 32;
			Item.height = 48;
			Item.maxStack = 99;
			Item.value = 100;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.GoldGlobe>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gold Globe");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ItemID.GoldBar, 5);
			recipe.SetResult(this);
			recipe.AddTile(106);
			recipe.AddRecipe();
		}
	}
}
