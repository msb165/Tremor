using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class ChristmasFireplace:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 32;
			Item.maxStack = 99;
			Item.rare = 1;
			Item.createTile = ModContent.TileType<Tiles.ChristmasFireplace>();
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Christmas Fireplace");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.RedBrick, 10);
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.AddIngredient(ItemID.Torch, 2);
			recipe.SetResult(this);
			recipe.AddTile(18);
			recipe.AddRecipe();
		}
	}
}
