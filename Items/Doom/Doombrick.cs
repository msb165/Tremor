using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.Items.Doom
{
	public class Doombrick:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 12;
			Item.height = 12;
			Item.maxStack = 999;
			Item.useTurn = true;
			Item.value = 2000;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.rare = 7;
			Item.useStyle = 1;
			Item.consumable = true;
			Item.createTile = ModContent.TileType<Tiles.DoombrickTile>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Doombrick");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<DoombrickWall>(), 4);
			recipe.SetResult(this, 1);
			recipe.AddTile(17);
			recipe.AddRecipe();

			recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Doomstone>(), 1);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.SetResult(this, 50);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
