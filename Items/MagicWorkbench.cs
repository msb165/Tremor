using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items
{
	public class MagicWorkbench:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 50;
			Item.height = 26;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;

			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<Tiles.MagicWorkbenchTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Magic Workbench");
			// Tooltip.SetDefault("Allows you to create scientific-magical things");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ItemID.Wood, 15);
			recipe.AddIngredient(ItemID.ManaCrystal, 2);
			recipe.AddIngredient(ItemID.MagicHat, 1);
			recipe.AddIngredient(ItemID.Bunny, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
