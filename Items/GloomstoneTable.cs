using Terraria.ModLoader;

namespace Tremor.Items
{
	public class GloomstoneTable:TremorModItem
	{
		public override void SetDefaults()
		{

			Item.width = 48;
			Item.height = 32;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 15;
			Item.useStyle = 1;
			Item.rare = 1;
			Item.consumable = true;
			Item.value = 2000;
			Item.createTile = ModContent.TileType<Tiles.GloomstoneTable>();
		}

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Gloomstone Table");
			// Tooltip.SetDefault("");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe();
			recipe.AddIngredient(ModContent.ItemType<Gloomstone>(), 8);
			recipe.SetResult(this);
			recipe.AddTile(17);
			recipe.AddRecipe();
		}
	}
}
