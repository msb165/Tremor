using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class EvershinyBar:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 30;
			Item.height = 24;
			Item.maxStack = 999;
			Item.value = 10000;
			Item.rare = 8;
			Item.createTile = ModContent.TileType<Tiles.EvershinyBar>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Evershining Bar");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.HallowedBar, 1);
			recipe.AddIngredient(ItemID.Ectoplasm, 2);
			recipe.SetResult(this);
			recipe.AddTile(133);
			recipe.AddRecipe();
		}
	}
}
